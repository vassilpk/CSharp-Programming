//  Write a program that reads an integer number n from the console and 
//  prints all the numbers in the interval [1..n], each on a single line.


using System;

class PrintNumbersInInterval
{
    static void Main()
    {
        uint endOfInterval;

        Console.WriteLine("Please enter the last number of the interval [1..n] :");

        while (!uint.TryParse(Console.ReadLine(), out endOfInterval))
        {
            Console.WriteLine(" Incorrect number format");
        }

        for (int i = 1; i < (int)endOfInterval+1; i++)
        {
            Console.WriteLine(i);
        }
    }
}
