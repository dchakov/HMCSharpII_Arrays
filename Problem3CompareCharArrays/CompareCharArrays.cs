//Problem 3. Compare char arrays
//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Please, enter some text");
        string textOne = Console.ReadLine();
        char[] arrayOne = textOne.ToCharArray();
        Array.Sort(arrayOne);

        Console.WriteLine("Please, enter some text");
        string textSecond = Console.ReadLine();
        char[] arraySecond = textSecond.ToCharArray();
        Array.Sort(arraySecond);

        bool isEqual = false;

        Console.WriteLine();
        Console.WriteLine("Sorted Arrays");
        Console.WriteLine(arrayOne);
        Console.WriteLine(arraySecond);
        Console.WriteLine();

        for (int i = 0; i < arrayOne.Length; i++)
        {
            for (int j = 0; j < arraySecond.Length; j++)
            {
                if (arrayOne[i] == arraySecond[j])
                {
                    Console.WriteLine("Element {0} with index {1} from first array is equal to element with index {2} from second array", arrayOne[i], i, j);
                    isEqual = true;
                }
            }
        }
        if (isEqual == false)
        {
            Console.WriteLine("No equals");
        }
        
    }
}

