using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Lib
{
    public interface ICalculator
    {
        decimal Add(decimal num1, decimal num2);
        decimal Subtract(decimal numb1, decimal numb2);
        decimal Multiply(decimal numb1, decimal numb2);
        decimal Divide(decimal numb1, decimal numb2);
    }
}
