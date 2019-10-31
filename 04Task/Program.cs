using System;

// Напишете програма, която намира максимална редица от последователни еднакви елементи в масив. Пример: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} → {2, 2, 2}

class Program
{
    static void Main()
    {
        Console.WriteLine("Моля въведете размера на първия масив");
        int n = int.Parse(Console.ReadLine());
        int[] myArray = new int[n];

        int start = 0;
        int len = 1;
        int bestStart;
        int bestLen = len;

        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] == myArray[i + 1])
            {
               
                len++;

                if (bestLen < len)
                {
                    bestLen = len;
                    start = i;
                }
            }
        }
    }
}

