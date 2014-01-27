using System;

/// <summary>
/// Write a program that finds the most frequent number in an array. 
/// Example:{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
/// </summary>
class MostFrequentElementInArray
{
    static void Main(string[] args)
    {
        string sequence = Console.ReadLine();
        int[] myArray = TransformInput(sequence);
        int wantedElement = FindMostFrequentElement(myArray);
        int elementCounter = 0;
        for (int index = 0; index < myArray.Length; index++)
        {
            if (wantedElement == myArray[index])
            {
                elementCounter++;
            } 
        }
        Console.WriteLine("{0} ( {1} times )", wantedElement, elementCounter);
    }

    /// <summary>
    /// A method with removes the comas and spaces in the input string and 
    /// transforms it into an array
    /// </summary>
    /// <param name="rawArray"></param>
    /// <returns> An array of elements extracted from the input string </returns>
    static int[] TransformInput(string rawArray)
    {
        char[] separator = new char[] { ',', ' ' };
        string[] input = rawArray.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        int[] arr = new int[input.Length];
        for (int index = 0; index < input.Length; index++)
        {
            arr[index] = int.Parse(input[index]);
        }
        return arr;
    }
    /// <summary>
    /// A method for finding the most frequent element in the array
    /// </summary>
    /// <param name="array"></param>
    /// <returns> The most frequent element </returns>

    static int FindMostFrequentElement(int[] array)
    {
        int counter = 0;
        int maxCounter = 0;
        int mostFrequentElement = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    counter++;
                }
            }
            if (counter > maxCounter)
            {
                maxCounter = counter;
                mostFrequentElement = array[i];
            }
            counter = 0;
        }
        return mostFrequentElement;
    }

}
