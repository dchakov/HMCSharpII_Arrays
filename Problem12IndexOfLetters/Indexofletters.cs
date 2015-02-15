//Problem 12. Index of letters
//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;
using System.Threading;
using System.Globalization;

class Indexofletters
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
        char[] alphabetArray = new char[52];
        for (int i = 0; i < 26; i++)
        {
            alphabetArray[i] = (char)(65 + i);
        }
        for (int i = 26; i < 52; i++)
        {
            alphabetArray[i] = (char)(97 + i - 26);
        }

        for (int i = 0; i < alphabetArray.Length; i++)
        {
            Console.Write(alphabetArray[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine("Please, enter a word");
        string word = Console.ReadLine();
        char[] letters = word.ToCharArray();

        Console.WriteLine();
        for (int i = 0; i < word.Length; i++)
        {
            Console.Write(Convert.ToString(letters[i]) + " " + "Has index = ");
            for (int j = 0; j < alphabetArray.Length; j++)
            {
                if (word[i] == alphabetArray[j])
                {
                    Console.Write(j);
                }
            }
            Console.WriteLine();

        }
    }
}
