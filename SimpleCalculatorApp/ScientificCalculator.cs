using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorApp
{
    public class ScientificCalculator : IScientificCalculator
    {
        public int Modular(int x, int y)
        {
            return x % y;
        }
    }
}
