using System;
using System.Linq;

class BitTowerOfDoom
{
    static int numberOfKnights(int[,] matr)
    {
        int count = 0;
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (matr[i, j] == 1) count++;
            }
        }
        return count;
    }

    static int sumFromMatrix(int[,] matr)
    {
        int sum = 0;
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                sum += matr[i, j] * (1 << (7 - j));
            }
        }
        return sum;
    }

    static void printMatrix(int[,] matr)
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write(matr[i, j]);
            }
            Console.WriteLine();
        }
    }
    static int getBit(int number, int position)
    {
        return (number >> position) & 1;
    }
    static void Main(string[] args)
    {
        int[,] field = new int[8, 8];
        for (int i = 0; i < 8; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
                field[7 - i, j] = getBit(currentNumber, 7 - j);
            }
        }

        int initialKnights = numberOfKnights(field);
        int fallen = 0;
        while (true)
        {
            string command = Console.ReadLine();
            if (command == "end") break;
            int attackerRow = 7 - int.Parse(Console.ReadLine());
            int attackerColumn = int.Parse(Console.ReadLine());
            command = Console.ReadLine();
            int defenderRow = 7 - int.Parse(Console.ReadLine());
            int defenderColumn = int.Parse(Console.ReadLine());

            field[attackerRow, attackerColumn] = 0;

            if (defenderColumn < 0 || defenderColumn > 7)
            {
                if (defenderRow == 7 || defenderRow == 6) fallen++;
                continue;
            }

            if (command == "kill")
            {
                if (field[defenderRow, defenderColumn] == 0)
                {
                    if ((defenderColumn != 0 && field[defenderRow, defenderColumn - 1] == 1) && !(defenderColumn != 7 && field[defenderRow, defenderColumn + 1] == 1))
                    {
                        field[defenderRow, defenderColumn - 1] = 0;
                        continue;
                    }
                    if (!(defenderColumn != 0 && field[defenderRow, defenderColumn - 1] == 1) && (defenderColumn != 7 && field[defenderRow, defenderColumn + 1] == 1))
                    {
                        field[defenderRow, defenderColumn + 1] = 0;
                        continue;
                    }
                    if (!(defenderColumn != 0 && field[defenderRow, defenderColumn - 1] == 1) && !(defenderColumn != 7 && field[defenderRow, defenderColumn + 1] == 1))
                    {
                        field[defenderRow, defenderColumn] = 1;
                    }
                }
            }

            if (command == "move")
            {
                if ((!(defenderColumn != 0 && field[defenderRow, defenderColumn - 1] == 1) && !(defenderColumn != 7 && field[defenderRow, defenderColumn + 1] == 1)))
                {
                    field[defenderRow, defenderColumn] = 1;
                }
            }
        }

        //printMatrix(field);
        Console.WriteLine(initialKnights);
        Console.WriteLine(numberOfKnights(field) + fallen);
        Console.WriteLine(sumFromMatrix(field));
    }
}