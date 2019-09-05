using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
