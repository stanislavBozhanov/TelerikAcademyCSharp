using System;
using System.Linq;

class EasterMister
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a = n - 1;
        int[] b = new int[n - 2];
        // top
        Console.Write(new string('.', n + 1));
        Console.Write(new string('*', n - 1));
        Console.Write(new string('.', n + 1));
        Console.WriteLine();
        //middle
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(new string('.', a));
            Console.Write("*");
            Console.Write(new string('.', (3 * n) - 1 - (2 * a)));
            Console.Write("*");
            Console.Write(new string('.', a));
            Console.WriteLine();
            b[i] = a;  
            a -= 2;
            if (a < 0)
            {
                a = 1;
            }
        }


        //ribbon
        Console.Write(".*");
        for (int i = 0; i < (3 * n - 3); i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(".");
            }
            else
            {
                Console.Write("#");
            }
        }
        Console.Write("*.");
        Console.WriteLine();

        Console.Write(".*");
        for (int i = 0; i < (3 * n - 3); i++)
        {
            if (i % 2 == 0)
            {
                Console.Write("#");
            }
            else
            {
                Console.Write(".");
            }
        }
        Console.Write("*.");
        Console.WriteLine();

        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(new string('.', b[n - 2 - i - 1]));
            Console.Write("*");
            Console.Write(new string('.', (3 * n) - 1 - (2 * b[n - 2 - i - 1])));
            Console.Write("*");
            Console.Write(new string('.', b[n - 2 - i - 1]));
            Console.WriteLine();
        }

        //bottom
        Console.Write(new string('.', n + 1));
        Console.Write(new string('*', n - 1));
        Console.Write(new string('.', n + 1));
        Console.WriteLine();
    }
}