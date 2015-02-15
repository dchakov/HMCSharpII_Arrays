//Problem 14. Quick sort
//Write a program that sorts an array of strings using the Quick sort algorithm.

using System;

class QuickSort
{
    static void Main()
    {
        Console.WriteLine("Please, enter string array no spaces");
        string text = Console.ReadLine();
        char[] myArray = text.ToCharArray();


        MyQuickSort(myArray, 0, myArray.Length - 1);

        Console.WriteLine();
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write(myArray[i] + " ");
        }
        Console.WriteLine();

    }

    private static void MyQuickSort(char[] myArray, int lo, int hi)
    {
        if (lo < hi)
        {
            int p = Partition(myArray, lo, hi);
            MyQuickSort(myArray, lo, p - 1);
            MyQuickSort(myArray, p + 1, hi);
        }
    }

    private static int Partition(char[] myArray, int lo, int hi)
    {
        int pivotIndex = (lo + hi) / 2;
        char pivotValue = myArray[pivotIndex];
        myArray[pivotIndex] = myArray[hi];
        myArray[hi] = pivotValue;

        int storeIndex = lo;
        char temp;
        for (int i = lo; i <= hi - 1; i++)
        {
            if (myArray[i] <= pivotValue)
            {
                temp = myArray[i];
                myArray[i] = myArray[storeIndex];
                myArray[storeIndex] = temp;
                storeIndex++;
            }
        }

        temp = myArray[storeIndex];
        myArray[storeIndex] = myArray[hi];
        myArray[hi] = temp;

        return storeIndex;
    }
}
