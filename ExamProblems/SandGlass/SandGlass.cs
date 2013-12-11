using System;
using System.Linq;

namespace SandGlass
{
    class SandGlass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.Write(new string('.', i));
                Console.Write(new string('*', n - (2 * i)));
                Console.Write(new string('.', i));
                Console.WriteLine();
            }

            Console.Write(new string('.', (n - 1) / 2));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', (n - 1) / 2));
            Console.WriteLine();

            for (int i = (n - 1) / 2 - 1; i >= 0; i--)
            {
                Console.Write(new string('.', i));
                Console.Write(new string('*', n - (2 * i)));
                Console.Write(new string('.', i));
                Console.WriteLine();
            }
        }
    }
}
