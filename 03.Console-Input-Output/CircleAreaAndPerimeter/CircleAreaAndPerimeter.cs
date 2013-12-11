//Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class CircleAreaAndPerimeter
{
    static void Main()
    {
        Console.WriteLine("Enter circle radius: ");
        int radius = int.Parse(Console.ReadLine());
        double circleArea = radius * radius * Math.PI;
        double circlePerimeter = 2 * radius * Math.PI;
        Console.WriteLine("The circle area is: {0:F2}", circleArea);
        Console.WriteLine("The circle perimeter is: {0:F2}", circlePerimeter);
    }
}
