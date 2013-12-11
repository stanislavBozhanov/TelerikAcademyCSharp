// Write a program that prints all the numbers from 1 to N.

using System;

class PrintNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i < n + 1; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}