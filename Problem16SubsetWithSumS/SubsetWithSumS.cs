//Problem 16.* Subset with sum S
//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.
//Example:
//input array	S	result
//2, 1, 2, 4, 3, 5, 2, 6	14	yes

using System;

class SubsetWithSumS
{
    static void Main()
    {
        Console.WriteLine("Please, enter sequence of numbers separated by comma");
        string textelements = Console.ReadLine();
        string[] elements = textelements.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Please, enter number S sum");
        int sum = int.Parse(Console.ReadLine());

        int[] numberArray = new int[elements.Length];
        for (int i = 0; i < elements.Length; i++)
        {
            numberArray[i] = int.Parse(elements[i]);
        }

        int count = 0;
        for (int i = 1; i <= Math.Pow(2, numberArray.Length) - 1; i++) // If lenght = 8 we need 10 000 000 binary = 128 decimal
        {
            int curentSum = 0;                                         
            for (int j = 0; j < numberArray.Length; j++)
            {
                int mask = 1 << j;        // 00000000 00100000 
                int nAndMask = i & mask;  // 00000000 00100000
                int bit = nAndMask >> j;  // 00000000 00000001
                if (bit == 1)
                {
                    curentSum += numberArray[j]; // sum those with 1 (one) bit 
                }
            }
            if (curentSum == sum)
            {
                count++;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("no subset");
        }
        else
        {
            Console.WriteLine("Yes");
        }
    }
}
