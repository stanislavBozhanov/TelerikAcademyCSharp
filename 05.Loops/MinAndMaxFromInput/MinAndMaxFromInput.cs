//Write a program that reads from the console a sequence of N integer numbers and returns
//the minimal and maximal of them.
using System;
using System.Linq;

class MinAndMaxFromInput
{
    static void Main()
    {
        Console.WriteLine("Enter number of elments: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the elements of the sequence: ");
        int[] sequence = new int[n];
        for (int i = 0; i < n; i++)
        {
            sequence[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Min element is: " + sequence.Min());
        Console.WriteLine("Max element is: " + sequence.Max());
    }
}
