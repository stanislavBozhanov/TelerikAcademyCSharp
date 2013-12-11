//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class ThirdBit
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine((num & (1 << 3)) != 0 ? "The bit is 1" : "The bit is 0");
    }
}
