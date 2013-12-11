//Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3)
//and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class PointWithinCircleAndOutRec
{
    static bool PointWithinCircle(double centerX, double centerY, double radius, double pointX, double pointY)
    {
        if (Math.Pow(centerX - pointX, 2) + Math.Pow(centerY - pointY, 2) <= radius * radius)
            return true;
        else
            return false;
    }
    static bool PointWithinRectangle(double top, double left, double width, double height, double pointX, double pointY)
    {
        if ((pointX >= left) && (pointX <= left + width) && (pointY <= top) && (pointY >= top - height))
            return true;
        else
            return false;
    }
    static void Main()
    {
        Console.WriteLine("Enter coordinates x and y of the point");
        double pointX = double.Parse(Console.ReadLine());
        double pointY = double.Parse(Console.ReadLine());
        Console.WriteLine("Is the point within the circle AND out of the rectangle?\n{0}",
            (PointWithinCircle( 1, 1, 3, pointX, pointY) && !PointWithinRectangle( -1, 1, 6, 2, pointX, pointY)));
    }
}