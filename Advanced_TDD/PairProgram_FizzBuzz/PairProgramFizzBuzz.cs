using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_TDD.PairProgram_FizzBuzz
{
    public class PairProgramFizzBuzz
    {
        public static string Speak(int v)
        {
            if(v % 3 == 0 && v % 5 == 0)
            {
                return "FizzBuzz";
            }
            if(isFizzy(v))
            {
                return "Fizz";
            }
            if(v % 5 == 0)
            {
                return "Buzz";
            }
            return v.ToString();
        }

        private static bool isFizzy(int input)
        {
            return input % 3 == 0;
        }
    }
}
