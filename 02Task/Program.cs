using System;

// Да се напише програма, която чете два масива от конзолата и проверява дали са еднакви 
// (два масива са еднакви, когато имат еднаква дължина и елементите им, записани под едни и същи индекси, са еднакви). 

class Program
{
    static void Main()
    {
        bool isequal = true;
        Console.WriteLine("Моля въведете размера на първия масив");
        int n = int.Parse(Console.ReadLine());
        int[] newArray = new int[n];

        //Console.WriteLine("Моля въведете стойност за елемент 0");
        //newArray[0] = int.Parse(Console.ReadLine());

        //Console.WriteLine("Моля въведете стойност за елемент 1");
        //newArray[1] = int.Parse(Console.ReadLine());

        //Console.WriteLine("Моля въведете стойност за елемент 2");
        //newArray[2] = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Моля въведете стойност за елемент {0}", i);
            newArray[i] = int.Parse(Console.ReadLine());
        }

        // Въвеждаме втория масив
        Console.WriteLine("Моля въведете размера на втория масив");
        int m = int.Parse(Console.ReadLine());
        int[] secondArray = new int[m];

        for (int i = 0; i < m; i++)
        {
            Console.WriteLine("Моля въведете стойност за елемент {0}", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        if (newArray.Length == secondArray.Length)
        {
            Console.WriteLine("Двата масива са с еднаква дължина");
            //Console.WriteLine(newArray[0] == secondArray[0]);
            //Console.WriteLine(newArray[1] == secondArray[1]);
            //Console.WriteLine(newArray[2] == secondArray[2]);

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i] == secondArray[i]);

                if (newArray[i] != secondArray[i])
                {
                    isequal = false;
                    break;
                }
            }
            Console.WriteLine((isequal)? "Масивите са равни":"Масивите не са равни");
        }
        else
        {
            Console.WriteLine("Двата масива не са равни");
        }
    }
}

