// Write a program that finds the biggest of three integers using nested if statements.

using System;

class BiggestInteger
{
    static void Main()
    {
        Console.WriteLine("Enter three inRtegers from the console: ");
        int firstInt = int.Parse(Console.ReadLine());
        int secondInt = int.Parse(Console.ReadLine());
        int thirdInt = int.Parse(Console.ReadLine());
        if (firstInt >= secondInt)
        {
            if (firstInt >= thirdInt)
            {
                Console.WriteLine("The biggest integer is: " + firstInt);
            }
            else
            {
                Console.WriteLine("The biggest integer is: " + thirdInt);   
            }
        }
        else
        {
            if (secondInt >= thirdInt)
            {
                Console.WriteLine("The biggest integer is: " + secondInt);
            }
            else
            {
                Console.WriteLine("The biggest integer is: " + thirdInt);
            }
        }
    }
}
