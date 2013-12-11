//Write an expression that checks if given integer is odd or even.

using System;

class EvenOrOddNumber
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("Number is even!");
        }
        else
        {
            Console.WriteLine("Number is odd!");
        }
    }
}

