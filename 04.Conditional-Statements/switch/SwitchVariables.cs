//Write a program that, depending on the user's choice inputs int, double or string variable. 
//If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end.
//The program must show the value of that variable as a console output. Use switch statement.

using System;

class SwitchVariables
{
    static void Main()
    {
        Console.WriteLine("Enter type choice: int, double or string: ");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "int":
            case "double":
                int x = int.Parse(Console.ReadLine());
                x += 1; 
                Console.WriteLine("Variable after change: " + x);
                break;
            case "string":

            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
}
