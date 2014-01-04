using System;
using System.Linq;

class BubbleSort
{
    // Bubble sort algorith
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 5, 32, 35, 67, 3, 1, 46, 78, 3, 3, 45, };

        for (int i = 1; i > array.Length -1; i++)
        {
            bool swap = false;
            for (int j = array.Length; j < i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    swap = true;
                    int temp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = temp;
                }
            }
            if (!swap)
            {
                break;
            }
        }
    }
}
