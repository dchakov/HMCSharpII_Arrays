//Problem 19.* Permutations of set
//Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
//Example:
//N	result
//3	{1, 2, 3} 
//  {1, 3, 2} 
//  {2, 1, 3} 
//  {2, 3, 1} 
//  {3, 1, 2} 
//  {3, 2, 1}

using System;
using System.Linq;

class Permutation
{
    static int[] myArray;
    static void Main()
    {
        Console.WriteLine("Please, enter number N");
        int numberN = int.Parse(Console.ReadLine());
        myArray = new int[numberN];
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = i + 1;
        }
        GetPermutations(myArray, 0);

    }

    static void GetPermutations(int[] arr, int k)
    {
        if (k == arr.Length)
        {
            Printloops();
        }
        else
        {
            for (int i = k; i < arr.Length; i++)
            {
                int temp = arr[i];
                arr[i] = arr[k];
                arr[k] = temp;
                GetPermutations(arr, k + 1);
                temp = arr[i];
                arr[i] = arr[k];
                arr[k] = temp;
            }
        }
    }
    static void Printloops()
    {
        Console.Write("{");
        for (int i = 0; i < myArray.Length-1; i++)
        {
            Console.Write("{0}, ", myArray[i]);
        }
        Console.Write(myArray[myArray.Length - 1]);
        Console.Write("}");
        Console.WriteLine();
    }
}