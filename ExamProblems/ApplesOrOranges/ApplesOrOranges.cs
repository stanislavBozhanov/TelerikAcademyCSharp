using System;
using System.Linq;

class ApplesOrOranges
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        if (number != 0)
        {
            if (number < 0)
            {
                number *= -1;
            }

            long sumOfOddDigits = 0;
            long sumOfEvenDigits = 0;
            long numberOfDigits = 0;
            long num = number;
            while (num != 0)
            {
                num = num / 10;
                numberOfDigits++;
            }
            for (int i = 0; i < numberOfDigits; i++)
            {
                long currentDigit = number % 10;
                if (currentDigit % 2 == 0)
                {
                    sumOfEvenDigits += currentDigit;
                }
                else
                {
                    sumOfOddDigits += currentDigit;
                }
                number = number / 10;
            }
            if (sumOfEvenDigits > sumOfOddDigits)
            {
                Console.WriteLine("apples {0}", sumOfEvenDigits);
            }
            else if (sumOfEvenDigits < sumOfOddDigits)
            {
                Console.WriteLine("oranges {0}", sumOfOddDigits);
            }
            else if (sumOfEvenDigits == sumOfOddDigits)
            {
                Console.WriteLine("both {0}", sumOfEvenDigits);
            }
        } 
        else
        {
            Console.WriteLine("both 0");
        }   
    }
}