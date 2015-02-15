//Problem 6. Maximal K sum
//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class MaximalKsum
{
    static void Main()
    {
        Console.WriteLine("Please, enter number N lenght of array");
        int numberN = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter number K element of array");
        int numberK = int.Parse(Console.ReadLine());
        
        while (numberK > numberN)
        {
            Console.WriteLine("Number K must be smaller than N ");
            Console.WriteLine("Please, enter number K element of array");
            numberK = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Please, enter {0} elements of array on a new line",numberN);
        int[] myarray = new int[numberN];
        for (int i = 0; i < numberN; i++)
        {
            myarray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        

        int maximalSum = 0;
        string sum = "";

        Array.Sort(myarray);
        for (int i = myarray.Length - 1; i >= myarray.Length - numberK; i--)
        {
            sum = sum +" "+ Convert.ToString(myarray[i]);
            maximalSum += myarray[i];
        }
        Console.WriteLine("Maximal sum of K elements {0} = {1}",sum,maximalSum);
    }
}