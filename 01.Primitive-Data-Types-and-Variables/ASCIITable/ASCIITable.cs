﻿//Write a program that prints the entire ASCII table of characters on the console.

using System;

class ASCIITable
{
    static void Main()
    {
        for (int c = 0; c < 127; c++ )
        {
            Console.WriteLine("Character: {0} = {1}", c, (char)c);
        }
    }
}
