// Input number of A10 pieces, Output which of A0-A9 will not be used
using System;
using System.Linq;

namespace Sheets
{
    class Sheets
    {
        static void Main()
        {
            int pieces = int.Parse(Console.ReadLine());
            int[] sheets = new int[11];
            sheets[0] = 1024;
            for (int i = 1; i < 11; i++)
            {
                sheets[i] = sheets[i - 1] / 2;
            }
            for (int i = 0; i < 11; i++)
            {
                if (pieces / sheets[i] == 0)
                {
                    Console.WriteLine("A{0}", i);
                }
                pieces = pieces % sheets[i];
            }
        }
    }
}
