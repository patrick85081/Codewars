using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWare
{
    public partial class Kata
    {
        public static string AlphabetPosition(string text)
        {
            var numbers = from word in text.ToLower()
                where char.IsLower(word)
                let number = word - 'a' + 1
                select number.ToString();

            return string.Join(" ", numbers);
        }
    }
}
