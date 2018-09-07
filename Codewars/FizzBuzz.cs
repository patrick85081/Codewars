namespace Codewars
{
    public class FizzBuzz
    {
        public string Create(int input)
        {
            string result = "";
            if (input % 3 == 0)
                result += "Fizz";
            if (input % 5 == 0)
                result += "Buzz";
            return string.IsNullOrEmpty(result) ? input.ToString() : result;
        }
    }
}