//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class trapezoidArea
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        decimal area = ((a + b)/ 2.0m ) * h;     // I use decimal if a + b is an odd number.
        Console.WriteLine("Area is: " + area);
    }
}
