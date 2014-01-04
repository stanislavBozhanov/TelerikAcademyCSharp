using System;
using System.Linq;

class MaxIncreasingSequence
{
    static void Main()
    {
        int[] myArray = { 3, 2, 3, 4, 5, 6, 7, 8, 2, 2, 4, 5, 6, 7 };

        int maxSequence = 0;
        int sequence = 1;
        string sequenceNumbers = "";
        string maxSequenceNumbers = "";
        for (int index = 0; index < myArray.Length - 1; index++)
        {
            if (myArray[index] < myArray[index + 1])
            {
                sequence++;
                sequenceNumbers += myArray[index] + " ";
            }
            else
            {
                if (maxSequence < sequence)
                {
                    maxSequence = sequence;
                    sequenceNumbers += myArray[index] + " ";
                    maxSequenceNumbers = sequenceNumbers;
                }
                sequence = 1;
                sequenceNumbers = "";
            }
        }
        if (maxSequence < sequence)
        {
            sequenceNumbers += myArray[myArray.Length - 1];
            maxSequenceNumbers = sequenceNumbers;
        }

        Console.WriteLine(maxSequenceNumbers);
    }
}