using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars
{
    public class DnaStrand
    {
        static Dictionary<char, char> complement = new Dictionary<char, char>()
        {
            {'A', 'T'},
            {'T', 'A'},
            {'C', 'G'},
            {'G', 'C'},
        };

        public static string MakeComplement(string dna)
        {
            Func<char, char> convert = c => complement.ContainsKey(c) ? complement[c] : c;
            return new string(dna.Select(convert).ToArray());
        }
    }
}