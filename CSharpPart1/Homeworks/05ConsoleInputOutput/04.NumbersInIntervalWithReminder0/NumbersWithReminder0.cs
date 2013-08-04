//  Write a program that reads two positive integer numbers and prints how many numbers p exist 
//  between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.


using System;

class NumbersWithReminder0
{
    static void Main()
    {
        uint number1, number2;
        uint numbersCounter = 0;

        Console.WriteLine("Please enter two positive integer numbers: ");

        while (! uint.TryParse(Console.ReadLine(), out number1))
        {
            Console.WriteLine(" Incorrect number format"); 
        }

        while (! uint.TryParse(Console.ReadLine(), out number2))
        {
            Console.WriteLine(" Incorrect number format"); 
        }

        for (uint i = Math.Min(number1, number2); i < (number1 + number2+1); i++)
        {
            if (i % 5 == 0)
            {
                numbersCounter++;
            } 
        }

        Console.WindowWidth = 85;
        Console.WriteLine("There are {0} numbers in the interval [{1},{2}] that can be devided by 5 witout reminder.",
            numbersCounter, number1, number2);
    }
}
