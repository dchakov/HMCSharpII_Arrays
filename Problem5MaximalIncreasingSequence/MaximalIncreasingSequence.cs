//Problem 5. Maximal increasing sequence
//Write a program that finds the maximal increasing sequence in an array.
//Example:
//input	result
//3, 2, 3, 4, 2, 2, 4
//2, 3, 4

using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Please, enter sequence of numbers separated by comma");
        string textelements = Console.ReadLine();
        string[] elements = textelements.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int[] numberArray = new int[elements.Length];
        for (int i = 0; i < elements.Length; i++)
        {
            numberArray[i] = int.Parse(elements[i]);
        }

        int counter1 = 1;
        int counter2 = 0;
        int currentString1 = 0;
        int currentSrting2 = 0;

        for (int i = 1; i < elements.Length; i++)
        {
            if (numberArray[i]-1 == numberArray[i - 1])
            {
                currentString1 = numberArray[i];
                counter1++;
            }
            else
            {
                if (counter1 >= counter2)
                {
                    counter2 = counter1;
                    currentSrting2 = currentString1;
                    counter1 = 1;
                }
            }
        }
        if (counter1 > counter2)
        {
            Console.Write(currentString1-counter1+1);
            for (int i = counter1 - 1; i >= 1; i--)
            {
                Console.Write("," + (currentString1-i +1));
            }
            Console.WriteLine();

        }
        else
        {
            Console.Write(currentSrting2 - counter2 +1);
            for (int i = counter2 -1 ; i >= 1; i--)
            {
                Console.Write("," + (currentSrting2-i +1));
            }
            Console.WriteLine();

        }
    }
}
