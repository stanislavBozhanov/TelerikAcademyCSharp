//Write a program that finds the greatest of given 5 variables.

using System;

class GreatestOfFive
{
    static void Main()
    {
        Console.WriteLine("Enter 5 variables: ");
        double firstVar = double.Parse(Console.ReadLine());
        double secondVar = double.Parse(Console.ReadLine());
        double thirdVar = double.Parse(Console.ReadLine());
        double forthVar = double.Parse(Console.ReadLine());
        double fifthVar = double.Parse(Console.ReadLine());
        double biggestVar = 0;
        if (biggestVar < firstVar)
        {
            biggestVar = firstVar;
        }
        if (biggestVar < secondVar)
        {
            biggestVar = secondVar;
        }
        if (biggestVar < thirdVar)
        {
            biggestVar = thirdVar;
        }
        if (biggestVar < forthVar)
        {
            biggestVar = forthVar;
        }
        if (biggestVar < fifthVar)
        {
            biggestVar = fifthVar;
        }
        Console.WriteLine("The biggest variable is: " + biggestVar);
    }
}
