using System;

class GivenBitCheckValue
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer i and the position of the bit you want to know: ");
        int i = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("The given bit is: {0} ", (i & (1 << b)) != 0 ? "The bit is 1" : "The bit is 0");
    }
}