//Problem 20.* Variations of set
//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
//Example:
//N	K	result
//3	2	  {1, 1} 
//        {1, 2} 
//        {1, 3} 
//        {2, 1} 
//        {2, 2} 
//        {2, 3} 
//        {3, 1} 
//        {3, 2} 
//        {3, 3}

using System;

class VariationsOfSet
{
    static int numberN;
    static int numberK;
    static int[] loops;

    static void Main()
    {
        Console.WriteLine("Please, enter number N");
        numberN = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter number K");
        numberK = int.Parse(Console.ReadLine());

        loops = new int[numberK];
        NestedLoops(0);

    }

    static void NestedLoops(int currentloop)
    {
        if (currentloop == numberK)
        {
            Printloops();
            return;
        }
        for (int i = 1; i <= numberN; i++)
        {
            loops[currentloop] = i;
            NestedLoops(currentloop + 1);
        }

    }

    static void Printloops()
    {
        Console.Write("{");
        for (int i = 0; i < numberK-1; i++)
        {
            Console.Write("{0}, ",loops[i]);
        }
        Console.Write(loops[numberK-1]);
        Console.Write("}");
        Console.WriteLine();
    }
}
