//Problem 1. Allocate array
//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

using System;

class AllocateArray
{
    static void Main()
    {
        int[] myIntArray = new int[20];

        for (int i = 0; i < myIntArray.Length; i++)
        {
            myIntArray[i] = i * 5;
            Console.WriteLine(myIntArray[i]);
        }
    }
}
