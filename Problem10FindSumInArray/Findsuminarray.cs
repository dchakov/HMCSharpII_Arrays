//Problem 10. Find sum in array
//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:
//array	S	result
//4, 3, 1, 4, 2, 5, 8	11	4, 2, 5

using System;

class Findsuminarray
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

        Console.WriteLine("Please, enter sum S");
        int sumS = int.Parse(Console.ReadLine());

        int currentSum = 0;
        int firstPosition = 0;
        int lastPosition = 0;
        bool isEqualSum = false;

        for (int i = 0; i < myArray.Length; i++)
        {
            if (isEqualSum)
            {
                break;
            }
            currentSum = myArray[i];

            for (int j = i + 1; j < myArray.Length; j++)
            {
                currentSum += myArray[j];

                if (currentSum < sumS)
                {
                    continue;
                }
                else if (currentSum > sumS)
                {
                    break;
                }
                else
                {
                    firstPosition = i;
                    lastPosition = j;
                    isEqualSum = true;
                    break;
                }
            }
        }
        if (currentSum == sumS)
        {
            Console.WriteLine(currentSum);
            for (int i = firstPosition; i <= lastPosition; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No such sum");
            Console.WriteLine("Sequence means more than 1 number");
        }
    }
}