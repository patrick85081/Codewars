using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public partial class Kata
    {
        public static string StringLetterCount(string str)
        {
            //Your code
            if (string.IsNullOrEmpty(str))
                return string.Empty;

            var letterCount = string.Join("",
                from c in str.ToLower()
                where char.IsLower(c)
                group c by c into charGroup
                orderby charGroup.Key
                select $"{charGroup.Count()}{charGroup.Key}");
            return letterCount;
        }
    }
}