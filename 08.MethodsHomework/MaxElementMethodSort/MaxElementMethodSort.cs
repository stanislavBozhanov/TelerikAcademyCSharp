using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxElementMethodSort
{
    //Write a method that return the maximal element in a portion of array of integers starting at given index.
    //Using it write another method that sorts an array in ascending / descending order.

    class MaxElementMethodSort
    {
        static int FindMaxElementInArray(int[] array, int start, int end)
        {
            int maxElement = int.MinValue;
            for (int i = start; i <= end; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                }
            }
            return maxElement;
        }
        static int[] SortArray(int[] array)
        {
            int[] sorted = new int[array.Length];
            for (int j = array.Length - 1; j >= 0 ; j--)
            {
                int maxElement = FindMaxElementInArray(array, 0, j);
                sorted[j] = maxElement;
            }
            return sorted;
        }

        static void Main()
        {
            int[] myArray = { 5, 2, 3, 45, 6, 78, 3, 5, 6, 7, 3, 67, 4, 2, 11, 1, 1, 1, 7 };

            int[] myArraySorted = SortArray(myArray);
        }
    }
}
