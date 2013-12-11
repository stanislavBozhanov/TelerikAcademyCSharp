//Declare a character variable and assign it with the symbol that has Unicode code 72.

using System;

class CharVariable
{
    static void Main()
    {
        char symbol = '\x0048';
        Console.WriteLine("The char variable with Unicode code 72 is: {0}", symbol);
    }
}
