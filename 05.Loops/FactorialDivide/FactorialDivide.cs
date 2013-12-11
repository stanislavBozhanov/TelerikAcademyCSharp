// Write a program that calculates N!/K! for given N and K (1<K<N).

using System;
using System.Numerics;

class FactorialDivide
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
        Console.WriteLine("Enter K and N (K < N): ");
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Factorial(n) / Factorial(k));
    }
}