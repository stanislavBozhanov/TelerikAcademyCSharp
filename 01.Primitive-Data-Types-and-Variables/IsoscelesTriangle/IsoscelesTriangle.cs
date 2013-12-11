//Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
//Use Windows Character Map to find the Unicode code of the © symbol. 
//Note: the © symbol may be displayed incorrectly

using System;

class IsoscelesTriangle
{
    static void Main()
    {
        char copyRight = '\u00A9';
        int counterOfCopyRight = 5; 
        int counterOfSpaces = 10; // First row will be 10 spaces from the begining
        for (int i = 0; i < 3; i++)
        {
            Console.Write(new string(' ', counterOfSpaces));
            for (int j = 0; j < counterOfCopyRight; j++)
            {
                Console.Write(copyRight);
            }
            //Next row will be +1 empty spaces from the begining and -2 symbols on the line
            counterOfSpaces++; 
            counterOfCopyRight -= 2;
            Console.WriteLine();
        }
    }
}
