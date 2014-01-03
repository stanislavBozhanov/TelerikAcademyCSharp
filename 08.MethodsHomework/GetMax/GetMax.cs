using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMax
{
    //Write a method GetMax() with two parameters that returns the bigger of two integers.
    //Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

    class GetMax
    {
        private static int GetMaxNum(int numOne, int numTwo)
        {
            if (numOne > numTwo)
            {
                return numOne;
            }
            else
            {
                return numTwo;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers: ");
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int bigger = GetMaxNum(firstNum, secondNum);
            int biggest = GetMaxNum(bigger, thirdNum);

            Console.WriteLine("Biggest number is: {0}", biggest);

        }
    }
}
