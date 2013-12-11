//Write a program that enters the coefficients a, b and c of a quadratic equation
//		a*x2 + b*x + c = 0

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter the coefficients of the quadratic equation");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("This is not a quadratic equation!");
        }
        else
        {
            double discriminant = (b * b) - (4 * a * c);
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("The equation roots are:\nX1: {0}\nX2: {1}", x1, x2);
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("The equaltion has only one root: {0}", x);
            }
            else if (discriminant < 0)
            {
                Console.WriteLine("This equations doesn't have solution!");
            }
        }
    }
}
