// Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
//Use the Euclidean algorithm (find it in Internet).

using System;
using System.Linq;

class GreatestCommonDivisor
{
    static int GreatestCommonDivisorMethod(int a, int b)
    {
        int n = Math.Min(a, b);
        int gcd = 1, i = 1;

        while (i <= n)
        {
            if (a % i == 0 && b % i == 0)
            {
                gcd = i;
            }
            i++;
        }
        return gcd;
    }
    static void Main()
    {
        Console.WriteLine("Enter two integers: ");
        int firstInt = int.Parse(Console.ReadLine());
        int secondInt = int.Parse(Console.ReadLine());
        Console.WriteLine(GreatestCommonDivisorMethod(firstInt, secondInt));
    }
}
