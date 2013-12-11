//Write an expression that calculates rectangle’s area by given width and height.

using System;

class RecArea
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine("Area = " + (width*height));
    }
}

