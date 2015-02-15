//Problem 8. Maximal sum
//Write a program that finds the sequence of maximal sum in given array.
//Example:
//input	result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8	2, -1, 6, 4
//Can you do it with only one loop (with single scan through the elements of the array)?

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please, enter sequence of numbers separated by comma");
        string text = Console.ReadLine();
        string[] elements = text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int[] myArray = new int[elements.Length];
        for (int i = 0; i < elements.Length; i++)
        {
            myArray[i] = int.Parse(elements[i]);
        }

        int sumNElements = 0;
        int index = 0;
        int firstNum = 0;
        int lastNum = 0;
        int maxSum = int.MinValue;

        for (int i = 0; i < elements.Length; i++)
        {
            if (sumNElements <= 0)
            {
                sumNElements = 0;
                index = i;
            }

            sumNElements += myArray[i];
            
            if (sumNElements > maxSum)
            {
                maxSum = sumNElements;
                firstNum = index;
                lastNum = i;
            }
        }
        Console.WriteLine();
        Console.Write(myArray[firstNum]);
        for (int i = firstNum + 1; i <= lastNum; i++)
        {
            Console.Write(", " + myArray[i]);
        }
        Console.WriteLine();

    }
}
