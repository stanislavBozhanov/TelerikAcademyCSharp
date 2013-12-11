//We are given integer number n, value v (v=0 or 1) and a position p. 
//Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
//    Example: n = 5 (00000101), p=3, v=1  13 (00001101)
//    n = 5 (00000101), p=2, v=0  1 (00000001)

using System;

class ChangeGivenBit
{
    static void Main()
    {
        Console.WriteLine("Enter an integer, bit position and a value you want to set");
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());
        int resetAndSetBit = (n & (~(1 << p))) | (v << p);
        Console.WriteLine("Before reset: {0}\nAfter reset: {1}", Convert.ToString(n, 2), Convert.ToString(resetAndSetBit, 2));
    }
}