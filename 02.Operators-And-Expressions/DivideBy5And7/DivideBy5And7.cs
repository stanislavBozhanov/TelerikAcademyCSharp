//Write a boolean expression that checks for given integer 
//if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class DivideBy5And7
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        bool divide = (num % 5 == 0) && (num % 7 == 0);
        Console.WriteLine(divide);
    }
}

