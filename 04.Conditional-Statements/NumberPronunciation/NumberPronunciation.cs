using System;

class NumberPronunciation
{
    static void PrintBelowTwenty(int numberOne)
    {
        switch (numberOne)
        {
            case 0:
                Console.Write(" ");
                break;
            case 1:
                Console.Write("One");
                break;
            case 2:
                Console.Write("Two");
                break;
            case 3:
                Console.Write("Three");
                break;
            case 4:
                Console.Write("Four");
                break;
            case 5:
                Console.Write("Five");
                break;
            case 6:
                Console.Write("Six");
                break;
            case 7:
                Console.Write("Seven");
                break;
            case 8:
                Console.Write("Eight");
                break;
            case 9:
                Console.Write("Nine");
                break;
            case 10:
                Console.Write("ten");
                break;
            case 11:
                Console.Write("Eleven");
                break;
            case 12:
                Console.Write("Twelve");
                break;
            case 13:
                Console.Write("Thirdteen");
                break;
            case 14:
                Console.Write("Fourteen");
                break;
            case 15:
                Console.Write("Fiftheen");
                break;
            case 16:
                Console.Write("Sixteen");
                break;
            case 17:
                Console.Write("Seventeen");
                break;
            case 18:
                Console.Write("Eighteen");
                break;
            case 19:
                Console.Write("Nighteen");
                break;
            default:
                Console.Write("Invalid input!");
                break;
        }
    }
    static void PrintBetweenTwentyAndNintyNine(int numberTwo)
    {
        switch (numberTwo)
        {
            case 2:
                Console.Write("Twenty");
                break;
            case 3:
                Console.Write("Thirdty");
                break;
            case 4:
                Console.Write("Forthy");
                break;
            case 5:
                Console.Write("Fifty");
                break;
            case 6:
                Console.Write("Sixty");
                break;
            case 7:
                Console.Write("Seventy");
                break;
            case 8:
                Console.Write("Eighty");
                break;
            case 9:
                Console.Write("Ninty");
                break;
        }
    }
    
    static void Main()
    {
        Console.WriteLine("Enter a number between 0 and 999: ");
        int number = int.Parse(Console.ReadLine());
        if (number <= 19)
        {
            PrintBelowTwenty(number);
            Console.WriteLine();
        }
        else if (number >19 && number < 100)
        {
            PrintBetweenTwentyAndNintyNine(number / 10);
            Console.Write(" ");
            PrintBelowTwenty(number % 10);
            Console.WriteLine();
        }
        else if (number >= 100 && number <= 999)
        {
            if (number % 100 == 0)
            {
                PrintBelowTwenty(number / 100);
                Console.Write(" Hundred");
                Console.WriteLine();
            }
            else if (number % 100 > 0 && number % 100 <=19)
            {
                PrintBelowTwenty(number / 100);
                Console.Write(" Hundred And ");
                PrintBelowTwenty(number % 100);
                Console.WriteLine();
            }
            else if (number % 100 >= 20)
            {
                PrintBelowTwenty(number / 100);
                Console.Write(" Hundred And ");
                PrintBetweenTwentyAndNintyNine((number / 10) % 10);
                Console.Write(" ");
                PrintBelowTwenty(number % 10);
                Console.WriteLine();
            }
        }
    }
}