// Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci:
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
//Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.

using System;

class FibonacciSequence
{
    static long Fibonacci(int n)
    {
        if (n <= 2)
        {
            return 1;
        }
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    static void Main()
    {
        long sum = 0;
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i < n + 1; i++)
        {
            sum += Fibonacci(i);
        }
        Console.WriteLine("The sum is: " + sum);
    }
}
