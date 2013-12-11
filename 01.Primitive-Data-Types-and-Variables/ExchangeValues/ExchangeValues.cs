//Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

class ExchangeValues
{
    static void Main()
    {
        int firstInt = 5;
        int secondInt = 10;
        int safeInt;
        Console.WriteLine("First integer is: {0}\nSecond integer is: {1}\n", firstInt, secondInt);
        safeInt = firstInt;
        firstInt = secondInt;
        secondInt = safeInt;
        Console.WriteLine("After exchange\n\nFirst integer is: {0}\nSecond integer is: {1}\n", firstInt, secondInt);
    }
}
