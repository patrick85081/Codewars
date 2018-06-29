using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public partial class Kata
    {
        public static string SumStrings(string a, string b)
        {
            var numbers1 = GetNumberGroup(a);
            var numbers2 = GetNumberGroup(b);
            
            return AddNumber(numbers1, numbers2);
        }

        private static IEnumerable<ulong> GetNumberGroup(string number)
        {
            var source = number.Where(c => char.IsDigit(c));
            var numbersGroup = source
                .Select((c, index) => new { Index = source.Count() - index - 1, Item = c })
                .GroupBy(item => item.Index / 10, item => item.Item)
                .OrderBy(group => @group.Key)
                .Select(group => Convert.ToUInt64(new string(@group.ToArray())));
            return numbersGroup;
        }

        private static string AddNumber(IEnumerable<ulong> numbers1, IEnumerable<ulong> numbers2)
        {
            var total = Enumerable.Zip(numbers1, numbers2, (n1, n2) => n1 + n2)
                .Concat(GetOtherNumbers(numbers1, numbers2))
                .ToList();

            for (int i = 0; i < total.Count(); i++)
            {
                if (total[i] >= Math.Pow(10, 10) && i + 1 < total.Count())
                {
                    total[i + 1] += (ulong) (total[i] / Math.Pow(10, 10));
                    total[i] = (ulong) (total[i] % Math.Pow(10, 10));
                }
            }

            return string.Join("",
                total.AsEnumerable()
                    .Reverse()
                    .Select(num => num.ToString()));
        }

        private static IEnumerable<ulong> GetOtherNumbers(IEnumerable<ulong> numbers1, IEnumerable<ulong> numbers2)
        {
            var count1 = numbers1.Count();
            var count2 = numbers2.Count();

            var min = Math.Min(count1, count2);
            IEnumerable<ulong> nexts;
            if (count1 > count2)
                nexts = numbers1.Skip(min);
            else if (count2 > count1)
                nexts = numbers2.Skip(min);
            else
                nexts = Enumerable.Empty<ulong>();
            return nexts;
        }
    }
}
