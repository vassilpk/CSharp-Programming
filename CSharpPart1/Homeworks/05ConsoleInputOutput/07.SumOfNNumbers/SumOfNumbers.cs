//  Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class SumOfNumbers
{
    static void Main()
    {
        double sum = 0; 
        double number = 0;
        uint numbersQuantity;

        Console.WriteLine("Please enter the quantity of the numbers to be summated.");

        while (!uint.TryParse(Console.ReadLine(), out numbersQuantity))
        {
            Console.WriteLine(" Incorrect number format");
        }

        for (int i = 0; i < numbersQuantity; i++)
        {
            Console.Write("Number{0} = ", i+1);
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine(" Incorrect number format");
            }
            sum += number;
        }
        Console.WriteLine("The sum of these {0} numbers is {1}.", numbersQuantity, sum);
    }
}
