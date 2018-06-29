using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public partial class Kata
    {
        private readonly static int groupLevel = 20;
        private readonly static decimal level = Convert.ToDecimal(Math.Pow(10, groupLevel));

        public static string SumStrings(string a, string b)
        {
            var numbers1 = GetNumberGroup(a);
            var numbers2 = GetNumberGroup(b);
            
            return AddNumber(numbers1, numbers2);
        }

        private static IEnumerable<decimal> GetNumberGroup(string number)
        {
            var source = number.Where(c => char.IsDigit(c));
            var numbersGroup = source
                .Select((c, index) => new { Index = source.Count() - index - 1, Item = c })
                .GroupBy(item => item.Index / groupLevel, item => item.Item)
                .OrderBy(group => @group.Key)
                .Select(group => Convert.ToDecimal(new string(@group.ToArray())));
            return numbersGroup;
        }

        private static string AddNumber(IEnumerable<decimal> numbers1, IEnumerable<decimal> numbers2)
        {
            var total = Enumerable.Zip(numbers1, numbers2, (n1, n2) => n1 + n2)
                .Concat(GetOtherNumbers(numbers1, numbers2))
                .ToList();

            for (int i = 0; i < total.Count(); i++)
            {
                if (total[i] >= level && i + 1 < total.Count())
                {
                    total[i + 1] += (decimal) (total[i] / level);
                    total[i] = (decimal) (total[i] % level);
                }
            }

            return string.Join("",
                total.AsEnumerable()
                    .Reverse()
                    .Select(num => num.ToString().Split('.').FirstOrDefault()));
        }

        private static IEnumerable<decimal> GetOtherNumbers(IEnumerable<decimal> numbers1, IEnumerable<decimal> numbers2)
        {
            var count1 = numbers1.Count();
            var count2 = numbers2.Count();

            var min = Math.Min(count1, count2);
            IEnumerable<decimal> nexts;
            if (count1 > count2)
                nexts = numbers1.Skip(min);
            else if (count2 > count1)
                nexts = numbers2.Skip(min);
            else
                nexts = Enumerable.Empty<decimal>();
            return nexts;
        }
    }
}
