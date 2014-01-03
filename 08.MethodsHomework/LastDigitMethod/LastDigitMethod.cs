using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigitMethod
{
    //Write a method that returns the last digit of given integer as an English word.
    //Examples: 512  "two", 1024  "four", 12309  "nine".

    class LastDigitMethod
    {
        static string LastDigitWord(int number)
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int lastDigit = number % 10;
            return digits[lastDigit];
        }
        static void Main()
        {
            Console.WriteLine("Enter an integer: ");
            int someInteger = int.Parse(Console.ReadLine());

            string result = LastDigitWord(someInteger);
            Console.WriteLine(result);
        }
    }
}
