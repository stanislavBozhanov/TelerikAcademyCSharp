using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerThanNeighbors
{
    //Write a method that checks if the element at given position in given array of integers 
    //is bigger than its two neighbors (when such exist).

    class BiggerThanNeighbors
    {
        static bool CheckNeighbors(int[] array, int position)
        {
            if (position > 0 && position < array.Length - 1)
            {
                if (array[position] > array[position - 1] && array[position] > array[position + 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            int[] myArray = { 1, 7, 3, 22, 32, 35, 1, 3, 3, 3, 1, 46, 78, 3, 3, 45, 45, 45, 45, 45, 45 };


            Console.WriteLine(CheckNeighbors(myArray, 0));
            Console.WriteLine(CheckNeighbors(myArray, 1));
            Console.WriteLine(CheckNeighbors(myArray, 3));
            Console.WriteLine(CheckNeighbors(myArray, 6));
        }
    }
}
