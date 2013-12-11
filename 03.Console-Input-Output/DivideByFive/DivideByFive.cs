//Write a program that reads two positive integer numbers and prints
//how many numbers p exist between them such that the reminder of the 
//division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

class DivideByFive
{
    static void Main()
    {
        Console.WriteLine("Enter two positive numbers: ");
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int p = 0;
        if (n < m)
        {
            for (int i = n; i <= m; i++)
            {
                int num = i;
                if (num % 5 == 0)
                {
                    p += 1;
                }
            }
            Console.WriteLine("p({0},{1}) = {2}", n, m, p);
        }
        else
        {
            Console.WriteLine("The first number must be bigger than the second");
        }
    }
}
