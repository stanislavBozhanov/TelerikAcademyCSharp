// Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

using System;

class BitSwapPlus
{       
    static void BitSwap(int firstBit, int secondBit, ref uint num)
    {
        uint bitOne = (num >> firstBit) & 1;
        uint bitTwo = (num >> secondBit) & 1;
        num = (uint)(num & (~(1 << firstBit)) | (bitTwo << firstBit));
        num = (uint)(num & (~(1 << secondBit)) | (bitOne << secondBit));
    }
    static void Main()
    {
        Console.WriteLine("Enter an integer: ");
        uint n = uint.Parse(Console.ReadLine());
        uint safe = n;
        Console.WriteLine("Enter bit p, bit q and k");
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        for (int i = 0; i < k; i++)
        {
            BitSwap(p + i, q + i, ref n);
        }
        Console.WriteLine("Before reset: {0}\nAfter reset:  {1}", Convert.ToString(safe, 2), Convert.ToString(n, 2));
    }
}
