using System;
using System.Linq;

class CompareArray
{
    static void Main()
    {
        Console.WriteLine("Enter lenght of first array and second array");
        int lenghtOne = int.Parse(Console.ReadLine());
        int lenghtTwo = int.Parse(Console.ReadLine());

        if (lenghtOne == lenghtTwo)
        {
            int[] fistArray = FillArray(lenghtOne);
            int[] secondArray = FillArray(lenghtTwo);
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
    static int[] FillArray(int lenght)
    {
        int[] array = new int[lenght];

        for (int index = 0; index < array.Length; index++)
        {
            array[index] = int.Parse(Console.ReadLine());
        }

        return array;

    }
    static bool AreElementsEqual(int[] arrayOne, int[] arrayTwo)
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