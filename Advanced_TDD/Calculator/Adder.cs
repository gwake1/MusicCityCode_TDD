using System;

namespace Advanced_TDD.Calculator
{
    public class Adder
    {
        public int Add(int? addend, int? augend)
        {
            if (addend < 0 | augend < 0)
            {
                throw new ArgumentException("Negative Argument");
            }
            return addend ?? 0 + augend ?? 0;
        }
    }
}