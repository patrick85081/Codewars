namespace Codewars
{
    public class FizzBuzz
    {
        public string Create(int input)
        {
            string word = input.ToString();
            string result = "";
            if (input % 3 == 0 || word.Contains("3"))
                result += "Fizz";
            if (input % 5 == 0 || word.Contains("5"))
                result += "Buzz";
            return string.IsNullOrEmpty(result) ? input.ToString() : result;
        }
    }
}