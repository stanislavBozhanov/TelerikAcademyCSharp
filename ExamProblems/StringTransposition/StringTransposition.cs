using System;
using System.Linq;

namespace StringTransposition
{
    class StringTransposition
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] strs = Enumerable.Range(0, n).Select(i => Console.ReadLine()).ToArray();
            for (int i = 0; i < strs.Max(s => s.Length); ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write(i < strs[j].Length ? strs[j][i] : ' ');
                }
                Console.WriteLine();
            }
        }
    }
}
