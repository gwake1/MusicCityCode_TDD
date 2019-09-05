namespace Advanced_TDD.Fizz_Buzz
{
    public class FizzBuzz
    {
        public static string Translate(int input)
        {
            if (input % 3 == 0 && input % 5 == 0)
            {
                return "fizzbuzz";
            }
            if (input % 3 == 0)
            {
                return "fizz";
            }
            if (input % 5 == 0)
            {
                return "buzz";
            }
            return input.ToString();
        }
    }
}