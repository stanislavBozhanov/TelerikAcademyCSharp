// Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. 
//Use a sequence of if statements.

using System;

class SignOfProduct
{
    static void Main()
    {
        Console.WriteLine("Enter three integers: ");
        int firstInt = int.Parse(Console.ReadLine());
        int secondInt = int.Parse(Console.ReadLine());
        int thirdInt = int.Parse(Console.ReadLine());
        if (firstInt != 0 && secondInt != 0 && thirdInt != 0)
        {
            if (firstInt > 0)
            {
                if (secondInt > 0)
                {
                    if (thirdInt > 0)
                    {
                        Console.WriteLine("The sign of the product is '+' ");
                    }
                    else
                    {
                        Console.WriteLine("The sign of the product is '-' ");                        
                    }
                }
                else
                {
                    if (thirdInt > 0)
                    {
                        Console.WriteLine("The sign of the product is: '-' ");
                    }
                    else
                    {
                        Console.WriteLine("The sign of the product is: '+' ");
                    }
                }
            }
            else
            {
                if (secondInt > 0)
                {
                    if (thirdInt > 0)
                    {
                        Console.WriteLine("The sign of the product is '-' ");
                    }
                    else
                    {
                        Console.WriteLine("The sign of the product is '+' ");
                    }
                }
                else
                {
                    if (thirdInt > 0)
                    {
                        Console.WriteLine("The sign of the product is: '+' ");
                    }
                    else
                    {
                        Console.WriteLine("The sign of the product is: '-' ");
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("The product is 0 and has no sign! ");
        }
    }
}
