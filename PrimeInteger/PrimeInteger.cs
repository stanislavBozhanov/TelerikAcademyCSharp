using System;
using System.Linq;

class PrimeInteger
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;
        for (int i = 2; i < number / 2; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        Console.WriteLine("Is number prime?");
        Console.WriteLine(isPrime);
    }
}