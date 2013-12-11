// Write a program to calculate the Nth Catalan number by given N.

using System;
using System.Linq;
using System.Numerics;

class CatalanNumbers
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
        Console.WriteLine("Enter the position of the desired number: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger catalanNumber = Factorial(2 * n) / (Factorial(n + 1) * Factorial(n));
        Console.WriteLine("Your nunber is: " + catalanNumber);
    }
}