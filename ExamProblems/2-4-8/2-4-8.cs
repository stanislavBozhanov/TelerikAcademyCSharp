using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long result = 0;
        long finalResult = 0;

        if (b == 2 || b == 4 || b == 8)
        {
            if (b == 2)
            {
                result = a % c;
            }
            else if (b == 4)
            {
                result = a + c;
            }
            else if (b == 8)
            {
                result = a * c;
            }

            if (result % 4 == 0)
            {
                finalResult = result / 4;
            }
            else if(result % 4 !=0)
            {
                finalResult = result % 4;
            }
            Console.WriteLine(finalResult);
            Console.WriteLine(result);
        }
    }
}