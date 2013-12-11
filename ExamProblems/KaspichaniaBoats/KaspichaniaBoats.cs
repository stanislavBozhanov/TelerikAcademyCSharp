using System;
using System.Linq;

class KaspichaniaBoats
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //top
        Console.Write(new string('.', n));
        Console.Write(new string('*', 1));
        Console.Write(new string('.', n));
        Console.WriteLine();

        for (int i = 0; i < 2 + ((n - 3) / 2) * 2; i++)
        {
            Console.Write(new string('.', n - 1 - i));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', i));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', i));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', n - 1 - i));
            Console.WriteLine();
        }

        Console.Write(new string('*', (n * 2) + 1));
        Console.WriteLine();
        //bottomTwo
        for (int i = n - 2; i >= (n - 1) / 2; i--)
        {
            Console.Write(new string('.', n - 1 - i));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', i));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', i));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', n - 1 -i));
            Console.WriteLine();
        }
        //bottom
        Console.Write(new string('.', (n + 1) / 2));
        Console.Write(new string('*', n));
        Console.Write(new string('.', (n + 1) / 2));

    }
}