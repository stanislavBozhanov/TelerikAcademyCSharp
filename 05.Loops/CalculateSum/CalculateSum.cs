// Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

using System;

class CalculateSum
{
    static long Factorial(int number)
    {
        long factorial = 1;
        for (int i = 1; i < number + 1; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
    static void Main()
    {
        Console.WriteLine("Enter X and N: ");
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        decimal sum = 1.0m;
        for (int i = 1; i < n + 1; i++)
        {
            sum += (decimal)(Factorial(i) / Math.Pow(x, i));
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}
