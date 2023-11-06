using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MyCalculator
    {
        public int Add(int x, int y) { return x + y; }
        public int Divide(int dividend, int divisor)
        {
            if (divisor == 0)
                throw new ArgumentException("Divisor argument can't be zero!");
            return dividend / divisor;
        }
    }
}
