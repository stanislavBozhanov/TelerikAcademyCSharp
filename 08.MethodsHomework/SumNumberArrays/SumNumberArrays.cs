using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumberArrays
{
    //Write a method that adds two positive integer numbers represented as arrays of digits
    //(each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
    //Each of the numbers that will be added could have up to 10 000 digits.

    class SumNumberArrays
    {
        static int[] SumArrays(int[] arrayOne, int[] arrayTwo)
        {
            int biggerLenght = Math.Max(arrayOne.Length, arrayTwo.Length);
            int smallerLenght = Math.Min(arrayOne.Length, arrayTwo.Length);
            int[] arraySum = new int[biggerLenght + 1];

            bool carry = false;


            for (int i = 0; i < smallerLenght ; i++)
            {
                int tempDigitSum = arrayOne[i] + arrayTwo[i];
                if (carry)
                {
                    tempDigitSum++;
                }
                if (tempDigitSum > 9)
                {
                    carry = true;
                }
                else
                {
                    carry = false;
                }
                arraySum[i] = tempDigitSum % 10;
            }

            for (int i = smallerLenght; i < biggerLenght; i++)
            {
                int tempDigitSum = arrayTwo[i];
                if (carry)
                {
                    tempDigitSum++;
                }
                if (tempDigitSum > 9)
                {
                    carry = true;
                }
                else
                {
                    carry = false;
                }
                arraySum[i] = tempDigitSum % 10;
            }

            if (carry)
            {
                arraySum[arraySum.Length - 1] = 1;
            }

            return arraySum;
        }
        static void Main(string[] args)
        {
            //int[] firstNumber = { 4, 3, 2, 6 };
            //int[] secondNumber = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            //tests
            int[] firstNumber = { 4, 3, 2, 6, 9, 9, 9, 9, 9 };
            int[] secondNumber = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            int[] result = SumArrays(firstNumber, secondNumber);
        }
    }
}
