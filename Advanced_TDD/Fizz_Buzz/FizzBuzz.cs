using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_TDD.Fizz_Buzz
{
    public class FizzBuzz
    {
        public static string Translate(int input)
        {
            if(input % 3 == 0)
            {
                return "fizz";
            }
            return input.ToString();
        }

    }
}
