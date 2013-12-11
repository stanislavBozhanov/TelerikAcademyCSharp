//Write a program to print the first 100 members of the sequence of Fibonacci: 
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;

class Fibonacci
{
    static void Main()
    {
        decimal n = 0;
        decimal m = 1;
        decimal sum = 0;
        Console.Write("{0}, {1}, ", n, m);
        for (int i = 0; i < 98; i++)
        {
            sum = n + m;
            n = m;
            m = sum;
            Console.Write("{0}, ", sum);
        }
    }
}