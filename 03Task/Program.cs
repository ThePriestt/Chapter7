using System;

// Да се напише програма, която сравнява два масива от тип char лексикографски (буква по буква) и проверява кой от двата е по-рано в лексикографската подредба. 

class Program
{
    static void Main()
    {
        bool isfirstbefore = true;
        Console.WriteLine("Моля въведете размера на първия масив");
        int n = int.Parse(Console.ReadLine());
        char[] firstArray = new char[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Въведете буква {0}", i);
            firstArray[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("Моля въведете размера на втория масив");
        int m = int.Parse(Console.ReadLine());
        char[] secondArray = new char[m];

        for (int i = 0; i < m; i++)
        {
            Console.WriteLine("Въведете буква {0}", i);
            secondArray[i] = char.Parse(Console.ReadLine());
        }

        for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
        {
            Console.WriteLine(firstArray[i] == secondArray[i]);

            if (firstArray[i] != secondArray[i])
            {
                if (firstArray[i] < secondArray[i])
                {
                    isfirstbefore = true;
                }
                else
                {
                    isfirstbefore = false;
                }
                break;
            }
            else
            {
                if (i == Math.Min(firstArray.Length, secondArray.Length) - 1)
                {
                    if (firstArray.Length < secondArray.Length)
                    {
                        isfirstbefore = true;
                    }
                    else
                    {
                        isfirstbefore = false;
                    }
                }
            }
        }
        //Console.WriteLine("Първата дума ли е по-напред {0}" ,isfirstbefore);
        Console.WriteLine((isfirstbefore) ? "Първата дума е по-напред" : "Втората дума е по-напред");
    }
}

