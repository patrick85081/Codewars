using System;
using System.Linq;

namespace Codewars
{
    public class Printer
    {
        public static string PrinterError(string printer)
        {
            var errorCount = printer.Where(p => 'm' < p || p < 'a')
                .Count();
            return $"{errorCount}/{printer.Length}";
        }
    }
}