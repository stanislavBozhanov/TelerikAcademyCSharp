// Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class SumOfInts
{
    static void Main()
    {
        Console.WriteLine("Enter three integers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("The sum of the entered integers is : " + (a + b +c));
    }
}
