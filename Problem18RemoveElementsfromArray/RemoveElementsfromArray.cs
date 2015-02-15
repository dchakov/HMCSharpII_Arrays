//Problem 18.* Remove elements from array
//Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array is sorted in increasing order.
//Print the remaining sorted array.
//Example:
//input	
//6, 1, 4, 3, 0, 3, 6, 4, 5  result //1, 3, 3, 4, 5
//4,5,6,7,1,2,3,4,5,6        result //1,2,3,4,5,6


using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter sequence of numbers separated by comma");
        string textelements = Console.ReadLine();
        string[] elements = textelements.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int[] numberArray = new int[elements.Length];
        for (int i = 0; i < elements.Length; i++)
        {
            numberArray[i] = int.Parse(elements[i]);
        }

        List<int> currentList = new List<int>();
        List<int> resultList = new List<int>();

        int currentCounter = 0;

        for (int i = 1; i <= Math.Pow(2, numberArray.Length) - 1; i++) // If lenght = 8 we need 10 000 000 binary = 128 decimal
        {
            for (int j = 0; j < numberArray.Length; j++)
            {
                int mask = 1 << j;        // 00000000 00100000 
                int nAndMask = i & mask;  // 00000000 00100000
                int bit = nAndMask >> j;  // 00000000 00000001
                if (bit == 1 && currentList.Count == 0)
                {
                    currentList.Add(numberArray[j]); // sum those with 1 (one) bit 
                }
                else if (bit == 1 && currentList.Count != 0)
                {
                    currentCounter = currentList.Count;

                    if (currentList[currentCounter - 1] <= numberArray[j])
                    {
                        currentList.Add(numberArray[j]);
                    }
                }
            }
            if (resultList.Count < currentList.Count)
            {
                resultList.Clear();
                for (int k = 0; k < currentList.Count; k++)
                {
                    resultList.Add(currentList[k]);
                }
            }
            currentList.Clear();
        }

        Console.WriteLine();
        for (int i = 0; i < resultList.Count; i++)
        {
            Console.Write(resultList[i] + " ");
        }
        Console.WriteLine();
    }
}

