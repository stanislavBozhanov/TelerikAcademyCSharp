//Safe compare of floating-point numbers with precision of 0.000001

using System;

class CompareFloat
{
    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        double secondNum = double.Parse(Console.ReadLine());
        bool compare = (Math.Abs(firstNum - secondNum) < 0.000001);
        Console.WriteLine(compare);
    }
}
