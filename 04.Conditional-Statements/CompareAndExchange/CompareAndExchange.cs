//Write an if statement that examines two integer variables and exchanges their values
//if the first one is greater than the second one.

using System;

class CompareAndExchange
{
    static void Main()
    {
        Console.WriteLine("Въведете две числа: ");
        int firstVar = int.Parse(Console.ReadLine());
        int secondVar = int.Parse(Console.ReadLine());
        if (firstVar > secondVar)
        {
            int tempVar = firstVar;
            firstVar = secondVar;
            secondVar = tempVar;
        }
        Console.WriteLine("First variable: {0}, Second variable: {1} ", firstVar, secondVar);
    }
}
