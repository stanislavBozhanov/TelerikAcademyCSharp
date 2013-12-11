//Write a program that reads the coefficients a, b and c of a quadratic equation
//ax2+bx+c=0 and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter the coefficients a, b and c of a quadratic equation: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double x1, x2;
        double d = ((b * b) - (4 * a * c));
        if (d >= 0)
        {
            x1 = ((-b + Math.Sqrt(b * b - 4 * a * c)) / (2.0 * a));
            x2 = ((-b - Math.Sqrt(b * b - 4 * a * c)) / (2.0 * a));
            Console.WriteLine("x1 = {0:F2} , x2 = {1:F2}", x1, x2);
        }
        else
        {
            Console.WriteLine("The equation has no real roots!");
        }
    }
}