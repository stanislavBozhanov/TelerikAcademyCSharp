// Sort 3 real values in descending order using nested if statements.

using System;

class DescendingOrder
{
    static void Main()
    {
        Console.WriteLine("Enter three integers: ");
        int firstInt = int.Parse(Console.ReadLine());
        int secondInt = int.Parse(Console.ReadLine());
        int thirdInt = int.Parse(Console.ReadLine());
        if (firstInt >= secondInt)
        {
            if (thirdInt >= firstInt)
            {
                Console.WriteLine("Descending order: {0}, {1}, {2} ", thirdInt, firstInt, secondInt );
            }
            else
            {
                if (thirdInt >= secondInt)
                {
                    Console.WriteLine("Descending order: {0}, {1}, {2} ", firstInt, thirdInt, secondInt );
                }
                else
                {
                    Console.WriteLine("Descending order: {0}, {1}, {2} ", firstInt, secondInt, thirdInt );
                }
            }
        }
        else
        {
            if (thirdInt >= firstInt)
            {
                if (thirdInt >= secondInt)
                {
                    Console.WriteLine("Descending order: {0}, {1}, {2} ", thirdInt, secondInt, firstInt);
                }
                else
                {
                    Console.WriteLine("Descending order: {0}, {1}, {2} ", secondInt, thirdInt, firstInt);
                }
            }
            else
            {
                Console.WriteLine("Descending order: {0}, {1}, {2} ", secondInt, firstInt);
            }
        }
    }
}
