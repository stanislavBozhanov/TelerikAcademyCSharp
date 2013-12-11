//Write a program to read your age from the console and print how old you will be after 10 years.

using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Enter your current age:");
        int ageNow = int.Parse(Console.ReadLine());
        if (ageNow > 0 && ageNow < 150)
        {
            Console.WriteLine("You current age is {0} and after 10 years you will be {1}", ageNow, ageNow + 10);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
