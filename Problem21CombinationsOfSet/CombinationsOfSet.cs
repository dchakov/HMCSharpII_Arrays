//Problem 21.* Combinations of set
//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
//Example:
//N	K	result
//5	2	{1, 2} 
//      {1, 3} 
//      {1, 4} 
//      {1, 5} 
//      {2, 3} 
//      {2, 4} 
//      {2, 5} 
//      {3, 4} 
//      {3, 5} 
//      {4, 5}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CombinationsOfSet
{
    static void Main()
    {
        Console.WriteLine("Please, enter number N");
        int numberN = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter number K");
        int numberK = int.Parse(Console.ReadLine());

        List<int> mylist= new List<int>();
        for (int i = 0; i < numberN; i++)
        {
            mylist.Add(i + 1);
        }
        var rezult = GetPermutations(mylist, numberK);

        foreach (var perm in rezult)
        {
            foreach (var c in perm)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }
    }

    static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> items, int count)
    {
        int i = 0;
        foreach (var item in items)
        {
            if (count == 1)
                yield return new T[] { item };
            else
            {
                foreach (var result in GetPermutations(items.Skip(i + 1), count - 1))
                    yield return new T[] { item }.Concat(result);
            }
            ++i;
        }
    }
}


