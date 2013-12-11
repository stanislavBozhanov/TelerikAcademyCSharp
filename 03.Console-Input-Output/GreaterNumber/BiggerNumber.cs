//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class BiggerNumber
{
    static void Main()
    {
        Console.WriteLine("Enter two integers: ");
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("The greater number is: " + Math.Max(n, m));
    }
}
