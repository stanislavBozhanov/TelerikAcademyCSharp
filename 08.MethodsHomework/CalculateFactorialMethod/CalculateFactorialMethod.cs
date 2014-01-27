using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CalculateFactorialMethod
{
    class CalculateFactorialMethod
    {
        static BigInteger CalculateFactorial(int inputNumber)
        {
            BigInteger factorial = 1;
            while (inputNumber > 0)
            {
                factorial *= inputNumber;
                inputNumber--;
            }
            return factorial;
        }
        static void Main()
        {
        }
    }
}
