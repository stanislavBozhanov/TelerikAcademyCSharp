//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

class IsPointWithinCircle
{
    static bool PointWithinCircle(double centerX, double centerY, double radius, double pointX, double pointY)
    {
        if (Math.Pow(pointX - centerX, 2) + Math.Pow(pointY - centerY, 2) <= radius * radius)
            return true;
        else
            return false;
    }
    static void Main()
    {
        Console.WriteLine("Enter the point coordinates x and y: ");
        double pointX = double.Parse(Console.ReadLine());
        double pointY = double.Parse(Console.ReadLine());
        Console.WriteLine("Is the given point within the circle?\n{0}", 
            PointWithinCircle(0, 0, 5, pointX, pointY));
    }
}

