using System;
using System.Linq;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        int[] myArray = { 2, 4, 5, 1, 3, 3, 3, 3, 2, 2, 2, 1, 1, 2, 2, 3, 3, 3, 3, 3 };

        int sequenceLenght = 1;
        int maxSequenceLenght = 0;
        string sequenceNumbers = "";
        string maxSequenceNumbers = "";

        for (int index = 0; index < myArray.Length - 1; index++)
        {
            if (myArray[index] == myArray[index + 1])
            {
                sequenceLenght++;
                sequenceNumbers += myArray[index] + " ";
                if ((index == myArray.Length - 2) && (sequenceLenght > maxSequenceLenght))
                {
                    maxSequenceLenght = sequenceLenght;
                    sequenceNumbers += myArray[index] + " ";
                    maxSequenceNumbers = sequenceNumbers;
                }
            }
            else
            {
                if (sequenceLenght > maxSequenceLenght)
                {
                    maxSequenceLenght = sequenceLenght;
                    sequenceNumbers += myArray[index] + " ";
                    maxSequenceNumbers = sequenceNumbers;
                }
                sequenceLenght = 1;
                sequenceNumbers = "";
            }
        }
        Console.WriteLine(maxSequenceNumbers);
    }
}