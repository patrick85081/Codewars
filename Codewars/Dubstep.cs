namespace Codewars
{
    public class Dubstep
    {
        private const string OneSpace= " ";
        private const string TwoSpace = "  ";

        public string SongDecoder(string song)
        {
            return song.Replace("WUB", OneSpace)
                .Replace(TwoSpace, OneSpace)
                .Replace(TwoSpace, OneSpace)
                .Trim();
        }
    }
}