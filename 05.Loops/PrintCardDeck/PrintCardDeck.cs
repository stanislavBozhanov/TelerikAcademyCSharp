// Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
//The cards should be printed with their English names. Use nested for loops and switch-case.

using System;
using System.Linq;

class PrintCardDeck
{
    static void CardName(int numberOne)
    {
        switch (numberOne)
	    {
            case 1:
                Console.Write("Two");
                break;
            case 2:
                Console.Write("Three");
                break;
            case 3:
                Console.Write("Four");
                break;
            case 4:
                Console.Write("Five");
                break;
            case 5:
                Console.Write("Six");
                break;
            case 6:
                Console.Write("Seven");
                break;
            case 7:
                Console.Write("Eight");
                break;
            case 8:
                Console.Write("Nine");
                break;
            case 9:
                Console.Write("ten");
                break;
            case 10:
                Console.Write("Jack");
                break;
            case 11:
                Console.Write("Queen");
                break;
            case 12:
                Console.Write("King");
                break;
            default:
                Console.Write("Invalid card!");
                break;
	    }
    }
    static void CardColor(int numberTwo)
    {
        switch (numberTwo)
        {
            case 1:
                Console.Write("sapdes");
                break;
            case 2:
                Console.Write("clubs");
                break;
            case 3:
                Console.Write("hearths");
                break;
            case 4:
                Console.Write("diamonds");
                break;
            default:
                Console.Write("Invalid color");
                break;
        }
    }
    static void Main()
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 12; j++)
            {
                CardName(j);
                Console.Write(" of ");
                CardColor(i);
                Console.WriteLine();
            }
        }
    }
}
