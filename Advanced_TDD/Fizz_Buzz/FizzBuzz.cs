namespace Advanced_TDD.Fizz_Buzz
{
    public class FizzBuzz
    {
        public static string Translate(int input)
        {
            if (isFizzy(input) && isBuzzy(input))
            {
                return "fizzbuzz";
            }
            if (isFizzy(input))
            {
                return "fizz";
            }
            if (isBuzzy(input))
            {
                return "buzz";
            }
            return input.ToString();
        }

        private static bool isFizzy(int input)
        {
            if (input % 3 == 0)
            {
                return true;
            }
            return false;
        }

        private static bool isBuzzy(int input)
        {
            if(input % 5 == 0)
            {
                return true;
            }
            return false;
        }
    }
}

   