// Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class SumOfFractions
{
    static void Main()
    {
        Console.WriteLine("Enter amount of fractions you want to add: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 1;
        for (int i = 2; i < n + 2; i++)
        {
            if (i % 2 == 0)
            {
                sum += 1.0 / i;
            }
            else
            {
                sum += -1.0 / i;
            }
        }
        Console.WriteLine("The sum is: {0:F3}", sum);
    }
}

