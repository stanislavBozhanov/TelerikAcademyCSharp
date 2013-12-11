// Enter 8 eight-bit numbers and put them in a grid. Count number and lenght of max lines
using System;
using System.Linq;

namespace Lines
{
    class Lines
    {
        static void Main()
        {
            int matrixSize = 8;
            int[,] matrix = new int[matrixSize, matrixSize]; 

            for (int i = 0; i < matrixSize; i++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int j = 0; j < matrixSize; j++)
                {
                    int bit = (number >> j) & 1;
                    matrix[i, j] = bit;
                }
            }

            int longestLineLenght = 0;;
            int longestCount = 0;

            for (int i = 0; i < matrixSize; i++)
            {
                int currentLineLenght = 0;
                for (int j = 0; j < matrixSize; j++)
                {
                    while (j < matrixSize && matrix[i, j] == 1)
                    {
                        currentLineLenght++;
                        j++;
                    }
                    if (currentLineLenght > longestLineLenght)
                    {
                        longestLineLenght = currentLineLenght;
                        longestCount = 1;
                    }
                    else if (longestLineLenght == currentLineLenght)
                    {
                        longestCount++;
                    }
                    currentLineLenght = 0;
                }
            }

            for (int j = 0; j < matrixSize; j++)
            {
                int currentLineLenght = 0;
                for (int i = 0; i < matrixSize; i++)
                {
                    while (i < matrixSize && matrix[i, j] == 1)
                    {
                        currentLineLenght++;
                        i++;
                    }
                    if (currentLineLenght > longestLineLenght)
                    {
                        longestLineLenght = currentLineLenght;
                        longestCount = 1;
                    }
                    else if (longestLineLenght == currentLineLenght)
                    {
                        longestCount++;
                    }
                    currentLineLenght = 0;
                }
            }

            if (longestLineLenght == 1)
            {
                longestCount = longestCount / 2;
            }
            Console.WriteLine(longestLineLenght);
            Console.WriteLine(longestCount);
        }
    }
}
