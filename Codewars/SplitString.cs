using System;
using System.Linq;

namespace Codewars
{
    public class SplitString
    {
        public static string[] Solution(string words)
        {
            return words.Select((c, index) => new {Index = index, Item = c})
                .GroupBy(item => item.Index / 2, item => item.Item)
                .Select(group => group.Count() < 2 ? group.Concat(new char[] {'_'}) : group)
                .Select(group => new string(group.ToArray()))
                .ToArray();
        }
    }
}