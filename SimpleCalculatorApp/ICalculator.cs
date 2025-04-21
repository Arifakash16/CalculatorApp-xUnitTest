using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorApp
{
    public interface ICalculator
    {
        public int Add(int num1, int num2);
        public int Subtract(int num1, int num2);  
        public int Multiply(int num1, int num2);
        public int Divide(int num1, int num2); 
    }
}
