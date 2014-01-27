using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSequence
{
    class SumOfSequence
    {
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

        static void Main(string[] args)
        {
            Console.WriteLine("Enter sequence of elements: ");
            string sequence = Console.ReadLine();
            // Transform the input string in an array removing empty entities, spaces and comas.
            int[] myArray = TransformInput(sequence); 

            Console.WriteLine("Enter desired sum: ");
            int inputSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < myArray.Length; i++)
            {
                int currentSum = 0;
                for (int j = i; j < myArray.Length; j++)
                {
    
                    if ((currentSum += myArray[j]) == inputSum)
                    {
                        Console.Write("{ ");
                        for (int k = 0, l = j - i + 1; k < l; k++)
                        {
                            Console.Write(myArray[i + k] + " ");
                        }
                        Console.Write("}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
