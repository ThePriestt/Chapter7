using System;

// Да се напише програма, която създава масив с 20 елемента от целочислен тип и инициализира всеки от елементите със стойност, 
// равна на индекса на елемента умножен по 5. Елементите на масива да се изведат на конзолата.

class Program
{
    static void Main()
    {
        int[] myArray = new int[20];

        myArray[0] = 0 * 5;
        myArray[1] = 1 * 5;
        myArray[2] = 2 * 5;
        myArray[3] = 3 * 5;
        myArray[4] = 4 * 5;
        myArray[5] = 5 * 5;

        for (int i = 0; i < 20 ; i++)
        {
            myArray[i] = 5 * i;
            Console.WriteLine(myArray[i]);
        }
    }
}

