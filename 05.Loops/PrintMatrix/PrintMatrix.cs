// Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:
// 1 2 3   for n = 3;
// 4 5 6
// 7 8 9
using System;
using System.Linq;

class PrintMatrix
{
    static void Main()
    {
        int startNumber = 1;
        Console.WriteLine("Enter size of matrix: ");
        int n = int.Parse(Console.ReadLine());
        for (int row = 1; row <= n; row++)
        {
            for (int col = row; col < row + n; col++)
            {
                Console.Write(startNumber + " ");
                startNumber++;
            }
            Console.WriteLine();
        }
    }
}
