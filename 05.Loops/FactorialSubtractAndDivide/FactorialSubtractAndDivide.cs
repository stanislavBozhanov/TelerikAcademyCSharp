// Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

class FactorialSubtractAndDivide
{
    static BigInteger Factorial(int number)
    {
        BigInteger factorial = 1;
        for (int i = 1; i < number + 1; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
    static void Main()
    {
        Console.WriteLine("Enter N and K (N < K): ");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine((decimal)((Factorial(n) * Factorial(k)) / Factorial(k - n)));
    }
}
