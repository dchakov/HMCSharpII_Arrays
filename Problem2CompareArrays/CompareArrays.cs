//Problem 2. Compare arrays
//Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Please,enter lenght of first array");
        int n = int.Parse(Console.ReadLine());
        int[] arrayOne = new int[n];

        Console.WriteLine("Please,enter {0} numbers",n);
        for (int i = 0; i < n; i++)
        {
            arrayOne[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Please,enter lenght of second array");
        int m = int.Parse(Console.ReadLine());
        int[] arraySecond = new int[n];

        Console.WriteLine("Please,enter {0} numbers", n);
        for (int i = 0; i < m; i++)
        {
            arraySecond[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (arrayOne[i] == arraySecond[j])
                {
                    Console.WriteLine("Element with index {0} from first array is equal to element with index {1} from second array",i,j);
                }
            }
        }

    }
}
