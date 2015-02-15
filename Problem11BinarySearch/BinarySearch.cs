//Problem 11. Binary search
//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;

class BinarySearch
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter a sequence of numbers separated by comma");
        string text = Console.ReadLine();
        string[] elements = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        int[] myArray = new int[elements.Length];
        for (int i = 0; i < elements.Length; i++)
        {
            myArray[i] = int.Parse(elements[i]);
        }
        Array.Sort(myArray);

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write(myArray[i]+" ");
        }
        Console.WriteLine();

        Console.WriteLine("Please enter number for search");
        int searchedNumber = int.Parse(Console.ReadLine());
        int imin = 0;
        int imax = myArray.Length-1;
        int imid = 0;

        while (imax >= imin)
        {
            imid = (imax + imin)/2;
            if (searchedNumber == myArray[imid])
            {
                break;  
            }
            else if (searchedNumber > myArray[imid])
            {
                imin = imid + 1;
            }
            else
            {
                imax = imid - 1;
            }
        }
        Console.WriteLine("Index of the given element is {0}",imid);
    }
}
