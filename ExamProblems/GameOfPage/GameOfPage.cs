// what is - cookie, broken cookie, cookie crumb, smile
// buy - page, (if cookie - > nothing), smile

using System;
using System.Linq;
using System.Globalization;
using System.Threading;

class GameOfPage
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int[,] cookieTray = new int[18, 18];
        decimal sumToPay = 0m;

        //Fill cookie tray
        for (int i = 1; i < 17; i++)
        {
            string input = Console.ReadLine();
            for (int j = 1; j < 17; j++)
            {
                cookieTray[i, j] = (int)Char.GetNumericValue(input[j - 1]);
            }
        }

        while (true)
        {
            string command = Console.ReadLine();
            if (command == "what is")
            {
                int row = int.Parse(Console.ReadLine()) + 1;
                int col = int.Parse(Console.ReadLine()) + 1;
                if (cookieTray[row, col] == 0)
                {
                    Console.WriteLine("smile");
                }
                if (cookieTray[row, col] == 1)
                {
                    if (IsCookie(row, col, cookieTray))
                    {
                        Console.WriteLine("cookie");
                    }
                    else if (IsCrumb(row, col, cookieTray))
                    {
                        Console.WriteLine("cookie crumb");
                    }
                    else
                    {
                        Console.WriteLine("broken cookie");
                    }
                }
            }
            if (command == "buy")
            {
                int row = int.Parse(Console.ReadLine()) + 1;
                int col = int.Parse(Console.ReadLine()) + 1;
                if (cookieTray[row, col] == 0)
                {
                    Console.WriteLine("smile");
                }
                if (cookieTray[row, col] == 1)
                {
                    if (IsCookie(row, col, cookieTray))
                    {
                        ResetCookie(row, col, cookieTray);
                        sumToPay += 1.79m;
                    }
                    else
                    {
                        Console.WriteLine("page");
                    }
                }
            }
            if (command == "paypal")
            {
                Console.WriteLine("{0:F2}", sumToPay);
                break;
            }
        }
    }
    static bool IsCookie(int row, int col, int[,] array)
    {
        return
            array[row - 1, col - 1] == 1 && array[row - 1, col] == 1 && array[row - 1, col + 1] == 1 &&
            array[row, col - 1] == 1 && array[row, col] == 1 && array[row, col + 1] == 1 &&
            array[row + 1, col - 1] == 1 && array[row + 1, col] == 1 && array[row + 1, col + 1] == 1;
    }
    static bool IsCrumb(int row, int col, int[,] array)
    {
        return
            array[row - 1, col - 1] == 0 && array[row - 1, col] == 0 && array[row - 1, col + 1] == 0 &&
            array[row, col - 1] == 0 && array[row, col] == 1 && array[row, col + 1] == 0 &&
            array[row + 1, col - 1] == 0 && array[row + 1, col] == 0 && array[row + 1, col + 1] == 0;
    }
    static void ResetCookie(int row, int col, int[,] array)
    {
        array[row - 1, col - 1] = 0;
        array[row - 1, col] = 0;
        array[row - 1, col + 1] = 0;
        array[row, col - 1] = 0;
        array[row, col] = 0;
        array[row, col + 1] = 0;
        array[row + 1, col - 1] = 0;
        array[row + 1, col] = 0;
        array[row + 1, col + 1] = 0;
    }
}