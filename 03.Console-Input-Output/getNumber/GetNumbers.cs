//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class GetNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        int sum = n;
        for (int i = n; i > 0; i--)
        {
            int m = int.Parse(Console.ReadLine());
            sum += m;
        }
        Console.WriteLine("Total = " + sum);
    }
}
