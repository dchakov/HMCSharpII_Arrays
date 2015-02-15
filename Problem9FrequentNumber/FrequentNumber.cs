//Problem 9. Frequent number
//Write a program that finds the most frequent number in an array.
//Example:
//input	result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	4 (5 times)

using System;

class FrequentNumber
{
    static void Main()
    {
        Console.WriteLine("Please, enter sequence of numbers separated by comma");
        string text = Console.ReadLine();
        string[] elements = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        int[] myArray = new int[elements.Length];
        for (int i = 0; i < elements.Length; i++)
        {
            myArray[i] = int.Parse(elements[i]);
        }
        int frequentNumber = 0;
        int currentCount = 1;
        int count = 0;

        Array.Sort(myArray);

        for (int i = 0; i < elements.Length; i++)
        {
            for (int j = i + 1; j < elements.Length; j++)
            {
                if (myArray[i] == myArray[j])
                {
                    currentCount++;
                }
            }
            if (count < currentCount)
            {
                count = currentCount;
                frequentNumber = myArray[i];
            }
            currentCount = 1;
            
        }
        Console.WriteLine("{0}({1} times)",frequentNumber,count);
    }
}

