//Problem 13.* Merge sort
//Write a program that sorts an array of integers using the Merge sort algorithm.

using System;

class MergeSort
{
    static void Main()
    {
        Console.WriteLine("Please, enter a sequence of numbers separated by comma");
        string text = Console.ReadLine();
        string[] elements = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        int[] myArray = new int[elements.Length];
        for (int i = 0; i < elements.Length; i++)
        {
            myArray[i] = int.Parse(elements[i]);
        }
        Console.WriteLine();

        int[] bArray = new int[elements.Length];

        TopDownSplitMerge(myArray, 0, elements.Length, bArray);

        
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write(myArray[i] + " ");
        }
        Console.WriteLine();
       
    }

    private static void TopDownSplitMerge(int[] myArray, int iBegin, int iEnd, int[] bArray)
    {
        if ((iEnd - iBegin) < 2)
        {
            return;
        }
        int iMiddle = (iEnd + iBegin) / 2;

        TopDownSplitMerge(myArray, iBegin, iMiddle, bArray);
        TopDownSplitMerge(myArray, iMiddle, iEnd, bArray);
        TopDownMerge(myArray, iBegin, iMiddle, iEnd, bArray);

        for (int k = iBegin; k < iEnd; k++)
        {
            myArray[k] = bArray[k];
        }
    }

    private static void TopDownMerge(int[] myArray, int iBegin, int iMiddle, int iEnd, int[] bArray)
    {
        int i0 = iBegin;
        int i1 = iMiddle;

        for (int j = iBegin; j < iEnd; j++)
        {
            if (i0 < iMiddle && (i1 >= iEnd || myArray[i0] <= myArray[i1]))
            {
                bArray[j] = myArray[i0];
                i0++;
            }
            else
            {
                bArray[j] = myArray[i1];
                i1++;
            }
        }
    }
}