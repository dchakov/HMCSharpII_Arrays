//Problem 7. Selection sort
//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;

class SelectionSsort
{
    static void Main()
    {
        Console.WriteLine("Enter lenght of array");
        int lenghtN = int.Parse(Console.ReadLine());
        Console.WriteLine("Please , enter {0} numbers of array on a new line",lenghtN);
        int[] myArray = new int[lenghtN];

        for (int i = 0; i < lenghtN; i++)
        {
            myArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        

        for (int i = 0; i < lenghtN -1; i++)
        {
            int smallest = 0;
            for (int j = i + 1; j < lenghtN; j++)
            {
                if (myArray[i] > myArray[j])
                {
                    smallest = myArray[j];
                    myArray[j] = myArray[i];
                    myArray[i] = smallest;
                }
            }

        }
        for (int i = 0; i < lenghtN; i++)
        {
            Console.Write(myArray[i] + " ");
        }
    }
}
