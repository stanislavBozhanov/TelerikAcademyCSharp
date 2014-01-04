using System;
using System.Linq;

class CompareCharArray
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter lenght of first array and second array");
        int lenghtOne = int.Parse(Console.ReadLine());
        int lenghtTwo = int.Parse(Console.ReadLine());

        if (lenghtOne == lenghtTwo)
        {
            Console.WriteLine("Enter {0} elements for fistArray", lenghtOne);
            char[] fistArray = FillArray(lenghtOne);
            Console.WriteLine("Enter {0} elements for secondArray", lenghtTwo);
            char[] secondArray = FillArray(lenghtTwo);

            Array.Sort(fistArray);
            Array.Sort(secondArray);

            if (AreElementsEqual(fistArray, secondArray))
            {
                Console.WriteLine("Arrays are equal");
            }
            else
            {
                Console.WriteLine("Arrays are not equal");
            }
        }
        else
        {
            Console.WriteLine("Arrays are not equal");
        }
    }
    // Method to fill the Array
    static char[] FillArray(int lenght)
    {
        char[] array = new char[lenght];

        for (int index = 0; index < array.Length; index++)
        {
            array[index] = char.Parse(Console.ReadLine());
        }

        return array;
    }
    // Method to compare Elements
    static bool AreElementsEqual(char[] arrayOne, char[] arrayTwo)
    {
        bool equal = true;
        for (int index = 0; index < arrayOne.Length; index++)
        {
            if (arrayOne[index] != arrayTwo[index])
            {
                equal = false;
            }
        }
        return equal;
    }
} 