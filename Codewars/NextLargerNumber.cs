using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars
{
    public class NextLargerNumber
    {
        public long Next(long input)
        {
            var inputNumbers = input.ToString()
                .ToCharArray()
                .Select(x => (long) char.GetNumericValue(x))
                .ToList();

            for (int index = inputNumbers.Count - 1; index > 0; index--)
            {
                if (inputNumbers[index] > inputNumbers[index - 1])
                {
                    var right = inputNumbers.GetRange(index, inputNumbers.Count - index);
                    var left = inputNumbers.GetRange(0, index); // include temp
                    
                    Swap(right, index, left);

                    left.AddRange(right.OrderBy(x => x));

                    return GetNumbericFromValueList(left);
                }
            }

            return -1;
        }

        private static void Swap(IList<long> right, int index, IList<long> left)
        {
            var temp = left[index - 1];
            for (int i = right.Count - 1; i >= 0; i--)
            {
                if (right[i] > temp)
                {
                    left[index - 1] = right[i];
                    right[i] = temp;
                    // Find First can Swap, is > t and min
                    break;
                }
            }
        }

        private static long GetNumbericFromValueList(IReadOnlyCollection<long> inputNumbers)
        {
            var count = inputNumbers.Count;
            var result = inputNumbers.Select((x, index) => x * (Math.Pow(10, (count - index - 1))))
                .Sum();

            return Convert.ToInt64(result);
        }
    }

    public static class ListExtension
    {
        public static List<TTarget> GetRange<TTarget>(this List<TTarget> source, int skip, int take) =>
            source.Skip(skip).Take(take).ToList();
    }
}