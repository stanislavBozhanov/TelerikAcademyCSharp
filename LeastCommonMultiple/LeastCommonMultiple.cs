using System;
using System.Linq;

class LeastCommonMultiple
{
    static void Main()
    {
        decimal integerOne = decimal.Parse(Console.ReadLine());
        decimal integerTwo = decimal.Parse(Console.ReadLine());

        decimal lcm = LessCommonMultiple(integerOne, integerTwo);
        Console.WriteLine(lcm);
    }
    static decimal LessCommonMultiple(decimal numberOne, decimal numberTwo)
    {
        decimal result = Math.Abs(numberOne * numberTwo) / GreatestCommonDivisor(numberOne, numberTwo);
        return result;
    }
    static decimal GreatestCommonDivisor(decimal numberOne, decimal numberTwo)
    {
        decimal remainder;

        while (numberTwo != 0)
        {
            remainder = numberOne % numberTwo;
            numberOne = numberTwo;
            numberTwo = remainder;
        }
        return numberOne;
    }
}
