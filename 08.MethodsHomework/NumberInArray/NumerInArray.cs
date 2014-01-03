using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInArray
{
    //Write a method that counts how many times given number appears in given array.
    //Write a test program to check if the method is working correctly.

    class NumerInArray
    {
        static int MostCommonNumber(int[] array, int number)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (number == array[i])
                {
                    counter++;
                }
            }
            return counter;
        }
        static void Main(string[] args)
        {
            int inputNumber = 3;
            int[] myArray = { 1, 7, 3, 22, 32, 35, 1, 3, 3, 3, 1, 46, 78, 3, 3, 45, 45, 45, 45, 45, 45 };
            int result = MostCommonNumber(myArray, inputNumber);
            Console.WriteLine(result);
        }
    }
}
