using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseDigits
{
    //Write a method that reverses the digits of given decimal number. Example: 256  652

    class ReverseDigits
    {
        static int ReverseNumber(int inputNumber, int result = 0)
        {
            if (inputNumber == 0)
            {
                return result;
            }
            else
            {
                return ReverseNumber(inputNumber / 10, result * 10 + inputNumber % 10);
            }
        }
        static void Main()
        {
            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Reverse: {0}", ReverseNumber(number));
        }
    }
}
