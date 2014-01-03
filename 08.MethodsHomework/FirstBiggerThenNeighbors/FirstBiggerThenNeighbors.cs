using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBiggerThenNeighbors
{
    //Write a method that returns the index of the first element in array that is bigger than its neighbors,
    //or -1, if there’s no such element.
    //Use the method from the previous exercise.

    class FirstBiggerThenNeighbors
    {
        static int FirstBiggerNumber(int[] array)
        {
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (CheckNeighbors(array, i))
                {
                    index = i;
                    break;
                }
            }
                return index;
        }
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
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 22, 32, 35, 1, 3, 3, 3, 1, 46, 78, 3, 3, 45, 45, 45, 45, 45, 45 };

            int result = FirstBiggerNumber(myArray);
            Console.WriteLine(result);
        }
    }
}
