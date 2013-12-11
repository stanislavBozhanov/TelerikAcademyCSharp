//Write a program that reads an integer number n from the console 
//and prints all the numbers in the interval [1..n], each on a single line.

using System;

class IntervalPrinting
{
    static void Main()
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The numbers in the interval [1,n] are: ");
        for (int i = 1; i <= n; i++)
        {
            int m = i;
            Console.WriteLine(m);
        }
    }
}
