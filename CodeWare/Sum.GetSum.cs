using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWare
{
    public partial class Sum
    {
        public int GetSum(int a, int b)
        {
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);
            return Enumerable.Range(min, (max - min + 1)).Sum();
        }
    }
}
