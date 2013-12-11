//Declare two string variables and assign them with following value:
//The "use" of quotations causes difficulties.
//Do the above in two different ways: with and without using quoted strings.

using System;

class EscapeSequence
{
    static void Main()
    {
        string quatations1 = @"The ""use"" of quotations causes difficulties";
        string quatations2 = "The \"use\" of quotations causes difficulties";
        Console.WriteLine(quatations1);
        Console.WriteLine(quatations2);
    }
}
