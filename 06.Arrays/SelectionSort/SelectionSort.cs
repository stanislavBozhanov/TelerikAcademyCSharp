using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 3, 2, 3, 4, 5, 6, 7, 8, 2, 2, 4, 5, 6, 7 };

            for (int i = 0; i < myArray.Length; i++)
            {
                int min = i;

                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[j] < myArray[i])
                    {
                        min = j;
                    }
                }
                Swap(myArray, i, min);
            }
            foreach (int item in myArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
