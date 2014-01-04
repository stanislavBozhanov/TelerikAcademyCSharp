using System;
using System.Linq;
class AllocateArray
{
    static void Main(string[] args)
    {
        int[] array = new int[20];

        for (int index = 0; index < array.Length; index++)
        {
            array[index] = index * 5;
        }

        for (int index = 0; index < array.Length; index++)
        {
            Console.WriteLine(array[index] + " ");
        }
    }
}
