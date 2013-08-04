//  We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. 
//  Example: 3, -2, 1, 1, 8  1+1-2=0.


using System;

class IsSumOfSubsetsZero
{
    static void Main()
    {
        int maxIterations;
        int numberOfMembers;
        int valueOfSubset;
        int subsetValuesCounter = 0;
        int sum = 0;
        Console.WriteLine("How many integers will be entered [1..32]");
        while (!int.TryParse(Console.ReadLine(), out numberOfMembers) || 
            (numberOfMembers < 1) || (numberOfMembers >32))
        {
            Console.WriteLine(" Incorrect number format");
        }
        int[] sequence = new int[numberOfMembers];
        Console.WriteLine("Please enter the value of a subset to be searched");
        while (!int.TryParse(Console.ReadLine(), out valueOfSubset))
        {
            Console.WriteLine(" Incorrect number format");
        }
        for (int i = 0; i < numberOfMembers; i++)
        {
             while (!int.TryParse(Console.ReadLine(), out sequence[i]))
             {
                Console.WriteLine(" Incorrect number format");
             }
        }
        maxIterations = (int)Math.Pow(2,numberOfMembers); 
        for (int i = 1; i < maxIterations; i++)
        {
            for (int k = 0; k < numberOfMembers; k++)
            {
                sum += ((i >> k) & 1) * sequence[k];
            }

            if (sum == valueOfSubset)
            {
                subsetValuesCounter++;
            }
            sum = 0;
        }
        Console.WriteLine("The value {0} is found in {1} sums of subsets.", valueOfSubset, subsetValuesCounter);
    }
}

