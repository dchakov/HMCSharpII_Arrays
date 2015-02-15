//Problem 4. Maximal sequence
//Write a program that finds the maximal sequence of equal elements in an array.
//Example:
//input	result
//2,3,3,3,3,3,33,7,8,9,9,9,9,9,99,9,9
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1
//2, 2, 2

using System;
using System.Collections.Generic;

class MaximalSequence
{
    static void Main()
    {
        Console.WriteLine("Please, enter sequence of numbers separated by comma");
        string textelements = Console.ReadLine();
        string[] elements = textelements.Split(new char[] {',',' '},StringSplitOptions.RemoveEmptyEntries);
       
        
        int counter1 = 1;
        int counter2 = 0;
        string currentString1 = "";
        string currentSrting2 = "";

        for (int i = 1; i < elements.Length; i++)
        {
            if (elements[i] == elements[i - 1])
            {
                currentString1 = elements[i];
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
            Console.Write(currentString1[0]);
            for (int i = 1; i < counter1; i++)
            {
                Console.Write(","+ currentString1);
            }
            Console.WriteLine();
            
        }
        else
        {
            Console.Write(currentSrting2[0]);
            for (int i = 1; i < counter2; i++)
            {
                Console.Write("," + currentSrting2);
            }
            Console.WriteLine();
            
        }

    }
}
