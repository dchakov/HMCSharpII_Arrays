//Problem 15. Prime numbers
//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;

class PrimeNumbers
{
    static void Main()
    {
        Console.WriteLine("Please,enter integer number in range 2.....10 000 000");
        int number = int.Parse(Console.ReadLine());
        bool[] myArray = new bool[number];

        for (int i = 0; i < number; i++)
        {
            myArray[i] = true;
        }
        
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            
            if (myArray[i] == true)
            {
                int m = 1;
                for (int j = i*i; j < number; j = m*i )
                {
                    myArray[j] = false;
                    m++;
                }
            }
        }
        Console.WriteLine();

        for (int i = 2; i < number; i++)
        {
            if (myArray[i] == true)
            {
                Console.Write(i + " ");
            }
        }
    }
}
