using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CodeWare
{
    public class NumberTranslation
    {
        private static Dictionary<int, string> one = new Dictionary<int, string>()
        {
            {0, "zero"},
            {1, "one"},
            {2, "two"},
            {3, "three"},
            {4, "four"},
            {5, "five"},
            {6, "six"},
            {7, "seven"},
            {8, "eight"},
            {9, "nine"},
            {10, "ten"},
            {11, "eleven"},
            {12, "twelve"},
            {13, "thirteen"},
            {14, "fourteen"},
            {15, "fifteen"},
            {16, "sixteen"},
            {17, "seventeen"},
            {18, "eighteen"},
            {19, "nineteen"},
            {20, "twenty"},
            {30, "thirty" },
            {40, "fourty" },
            {50, "fifty" },
            {60, "sixty" },
            {70, "seventy" },
            {80, "eighty" },
            {90, "ninety" }
        };
        public static string Number2Words(int number)
        {
            var length = number.ToString().Length;
            List<string> words = new List<string>();

            if (length >= 3)
            {
                if((number / 1000) > 0 )
                    words.Add($"{LessThousand(number / 1000)} thousand");

                if ((number % 1000) > 0)
                    words.Add($"{LessThousand(number % 1000)}");

                return string.Join(" ", words);
            }

            words.Add(LessHundren(number));


            return string.Join(" ", words);
        }

        private static string LessThousand(int number)
        {
            List<string> words = new List<string>();
            if ((number / 100 % 10) > 0)
                words.Add($"{one[(number / 100 % 10)]} hundren");

            if (number % 100 > 0)
                words.Add(LessHundren(number % 100));

            return string.Join(" ", words);
        }

        private static string LessHundren(int number)
        {
            if (one.ContainsKey(number))
                return one[number];
            else
            {
                var first = number % 10;
                var tmp = one[(number % 10)];
                var ttmp = one[(number / 10) % 100 * 10];
                return $"{ttmp}-{tmp}";
            }
        }
    }
}
