using System;
using System.Linq;

class PrimeIntegersInInterval
{
    static void Main()
    {
        int intervalStart = int.Parse(Console.ReadLine());
        int intervalEnd = int.Parse(Console.ReadLine());

        for (int i = intervalStart; i <= intervalEnd; i++)
        {
            if (isPrime(i))
            {
                Console.WriteLine(i);
            }
        }
    }
    static bool isPrime(int number)
    {
        bool isNumberPrime = true;
        for (int i = 2; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                isNumberPrime = false;
                break;
            }
        }
        return isNumberPrime;
    }
}