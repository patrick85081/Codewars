using System.Text.RegularExpressions;

namespace Codewars
{
    public class Dubstep
    {
        //private const string OneSpace= " ";
        //private const string TwoSpace = "  ";

        public string SongDecoder(string song)
        {
            return Regex.Replace(song, @"(WUB)+", " ")
                .Trim();

            //return song.Replace("WUB", OneSpace)
            //    .Replace(TwoSpace, OneSpace)
            //    .Replace(TwoSpace, OneSpace)
            //    .Trim();
        }
    }
}