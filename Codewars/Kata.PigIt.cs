using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public partial class Kata
    {
        public static string PigIt(string str)
        {
            //var concat = string.Join(" ",str.Split(' ').Select(Decoder));
            var concat = string.Join(" ",str.Split(' ').Select(Encoder));
            return concat;
        }

        private static string Decoder(string str)
        {
            return str.Substring(str.Length - 3, 1) + str.Substring(0, str.Length - 3);
        }

        private static string Encoder(string str)
        {
            return str.Substring(1) + str.Substring(0, 1) + "ay";
        }
    }
}
