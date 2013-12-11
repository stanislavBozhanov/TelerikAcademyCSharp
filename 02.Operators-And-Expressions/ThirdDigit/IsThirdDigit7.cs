//Write an expression that checks for given integer if its third digit 
//(right-to-left) is 7. E. g. 1732  true.

using System;

class IsThirdDigit7
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        bool thirdDigit = (num/100) % 10 == 7;
        Console.WriteLine(thirdDigit);
    }
}
