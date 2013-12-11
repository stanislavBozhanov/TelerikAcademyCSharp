using System;

class MaxPlatform2x2
{
    static void Main(string[] args)
    {
        int[,] matrix = 
        {
            { 23, 343, -44, 66, 3444, -123},
            { 342, 213, 33, 455, 33, 177 },
            { -33, -67, 33, -1000, 3423, -123123},
        };
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrix.GetLongLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLongLength(1) - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        Console.WriteLine("Best Platform is: ");
        Console.WriteLine(" {0}, {1} ", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1]);
        Console.WriteLine(" {0}, {1} ", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1]);
        Console.WriteLine("Best sum is: " + bestSum);
    }
}