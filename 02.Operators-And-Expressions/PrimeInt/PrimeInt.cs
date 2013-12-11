//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class PrimeInt
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        bool prime = (num % 2 == 0) && (num % 3 == 0) && (num % 5 == 0) && (num % 7 == 0) || 
            (num == 2) || (num == 3) || (num == 5) || (num == 7);
        Console.WriteLine(prime);
    }
}
