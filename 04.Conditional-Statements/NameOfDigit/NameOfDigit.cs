//Write program that asks for a digit and depending on the input 
//shows the name of that digit (in English) using a switch statement.

using System;

class NameOfDigit
{
    static void Main()
    {
        Console.WriteLine("Enter digit: ");
        int digit = int.Parse(Console.ReadLine());
        switch (digit)
        {
            case 0:
                Console.WriteLine("You entered 'zero' ");
                break;
            case 1:
                Console.WriteLine("You entered 'one' ");
                break;
            case 2:
                Console.WriteLine("You entered 'two' ");
                break;
            case 3:
                Console.WriteLine("You entered 'three' ");
                break;
            case 4:
                Console.WriteLine("You entered 'four' ");
                break;
            case 5:
                Console.WriteLine("You entered 'five' ");
                break;
            case 6:
                Console.WriteLine("You entered 'six' ");
                break;
            case 7:
                Console.WriteLine("You entered 'seven' ");
                break;
            case 8:
                Console.WriteLine("You entered 'eight' ");
                break;
            case 9:
                Console.WriteLine("You entered 'nine' ");
                break;
            default:
                Console.WriteLine("Invalid input! Please enter a digit.");
                break;
        }
    }
}