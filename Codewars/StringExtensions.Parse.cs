using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    //https://www.codewars.com/kata/convert-a-string-to-an-integer-with-any-specified-base
    public static class StringExtensions
    {
        public static int Parse(this string value, int fromBase)
        {
            if(value == null)
                throw new ArgumentNullException();
            else if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentException();
            else if(fromBase < 2 || 36 < fromBase)
                throw new ArgumentException();

            string chars = "0123456789abcdefghijklmnopqrstuvwxyz";

            var numbers = value.ToLower()
                .Reverse()
                .Select(num => chars.IndexOf(num));

            if (numbers.Any(num => num >= fromBase || num < 0))
                throw new FormatException();

            var sum = numbers.Select((num, index) => num * Math.Pow(fromBase, index))
                .Sum();

            if (sum > uint.MaxValue)
            {
                throw new OverflowException();
            }
            else
            {
                sum = sum > int.MaxValue ? sum - uint.MaxValue - 1 : sum;
            }

            return Convert.ToInt32(sum);
        }
    }
}
