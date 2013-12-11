using System;
using System.Linq;

class BinaryDigits
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] lastSixteenBits = new int[16];
        for (int i = 0; i < 16; i++)
        {
            lastSixteenBits[i] = (number >> i) & 1;
        }
        for (int i = 15; i >= 0; i--)
        {
            if (lastSixteenBits[i] == 1)
            {
                Console.Write(".#.");
            }
            else if (lastSixteenBits[i] == 0)
            {
                Console.Write("###");
            }
            if (i != 0)
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();
        for (int i = 15; i >= 0; i--)
        {
            if (lastSixteenBits[i] == 1)
            {
                Console.Write("##.");
            }
            else if (lastSixteenBits[i] == 0)
            {
                Console.Write("#.#");
            }
            if (i != 0)
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();
        for (int i = 15; i >= 0; i--)
        {
            if (lastSixteenBits[i] == 1)
            {
                Console.Write(".#.");
            }
            else if (lastSixteenBits[i] == 0)
            {
                Console.Write("#.#");
            }
            if (i != 0)
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();
        for (int i = 15; i >= 0; i--)
        {
            if (lastSixteenBits[i] == 1)
            {
                Console.Write("###");
            }
            else if (lastSixteenBits[i] == 0)
            {
                Console.Write("###");
            }
            if (i != 0)
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();
    }
}