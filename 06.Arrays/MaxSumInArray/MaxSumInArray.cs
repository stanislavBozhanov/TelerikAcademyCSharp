using System;
using System.Linq;

class MaxSumInArray
{
    static void Main()
    {
        //Write a program that reads two integer numbers N and K and an array of N elements from the console. 
        //Find in the array those K elements that have maximal sum.

        Console.WriteLine("Enter the numbers N and K: ");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int[] myArray = FillArray(n);
        Array.Sort(myArray);
        int sum = 0;
        if (k < n)
        {
            for (int index = 0; index < k; index++)
            {
                sum += myArray[myArray.Length - 1 - index];
            }
        }
        else
        {
            Console.WriteLine("You can't have that much elements!");
        }
    }
    static int[] FillArray(int lenght)
    {
        int[] array = new int[lenght];

        for (int index = 0; index < array.Length; index++)
        {
            Console.WriteLine("Enter element {0} of the array: ", index);
            array[index] = int.Parse(Console.ReadLine());
        }
        return array;
    }
}