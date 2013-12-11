using System;
using System.Linq;

class AmericanPie
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        decimal denominatorResult = new decimal();
        decimal nominatorResult = new decimal();
        if (b == d)
        {
            denominatorResult = b;
            nominatorResult = a + c;
        }
        else if (b != d)
        {
            denominatorResult = b * d;
            nominatorResult = (a * d) + (b * c);
        }
        if (nominatorResult == denominatorResult)
        {
            Console.WriteLine(1);
            Console.WriteLine(nominatorResult + "/" + denominatorResult);
        }
        else if (nominatorResult > denominatorResult)
        {
            Console.WriteLine("{0:F0}", nominatorResult / denominatorResult);
            Console.WriteLine(nominatorResult + "/" + denominatorResult);
        }
        else if (nominatorResult < denominatorResult)
        {
            Console.WriteLine("{0:F20}", nominatorResult / denominatorResult);
            Console.WriteLine(nominatorResult + "/" + denominatorResult);
        }
    }
}