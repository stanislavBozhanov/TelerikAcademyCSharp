using System;
using System.Linq;

class NightmareOnCodeStreet
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int[] numberArray = new int[input.Length];
        int numberOfDigits = 0;
        int sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '0' || input[i] == '1' || input[i] == '2' || input[i] == '3' || input[i] == '4' || input[i] == '5' || input[i] == '6' || input[i] == '7' || input[i] == '8' || input[i] == '9')
            {
                numberArray[i] = (int)Char.GetNumericValue(input[i]);
            }
            else
            {
                numberArray[i] = -1; 
            }
        }
        if (input.Length < 2)
        {
            Console.Write(0);
            Console.Write(" ");
            Console.Write(0);
        }
        if (input.Length >= 2)
        {
            for (int i = 1; i < numberArray.Length; i = i + 2)
            {
                if (numberArray[i] == -1)
                {
                    continue;
                }
                numberOfDigits++;
                sum += numberArray[i];
            }
            Console.Write(numberOfDigits);
            Console.Write(" ");
            Console.Write(sum);
        }
    }
}