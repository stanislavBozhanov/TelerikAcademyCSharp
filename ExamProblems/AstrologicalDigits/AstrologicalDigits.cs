// Gets nubmer and sums its digits till it's a 1 digit result
using System;
using System.Linq;

namespace AstrologicalDigits
{
    class AstrologicalDigits
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            byte[] digitCollect = new byte[number.Length];
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (byte.TryParse(number[i].ToString(), out digitCollect[i]))
                {
                    digitCollect[i] = byte.Parse(number[i].ToString());
                }
                else
                {
                    continue;
                }
                sum += digitCollect[i];
            }
            int safeSum = 0;
            while (sum > 9)
            {
                while (sum != 0)
                {
                    safeSum += sum % 10;
                    sum /= 10;
                }
                sum = safeSum;
                safeSum = 0;
            }
            Console.WriteLine(sum);
        }
    }
}
