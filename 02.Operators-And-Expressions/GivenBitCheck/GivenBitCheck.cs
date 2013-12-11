//Write a boolean expression that returns if the bit at position p (counting from 0)
//in a given integer number v has value of 1. Example: v=5; p=1  false
using System;

class GivenBitCheck
{
    static void Main()
    {
        Console.WriteLine("Add an integer and a bit position: ");
        int v = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine((v & (1 << p)) != 0 ? "True" : "False");
    }
}