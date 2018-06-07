using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWare
{
    public partial class Kata
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            return from name in names
                where name.Length == 4
                select name;
        }
    }
}
