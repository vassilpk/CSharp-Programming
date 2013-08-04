// Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.


using System;

class GreaterOfTwoNumbers
{
    static void Main()
    {
        float number1, number2;

        Console.WriteLine("Please enter two numbers to be compared: ");

        while (!float.TryParse(Console.ReadLine(), out number1))
        {
            Console.WriteLine(" Incorrect number format");
        }

        while (!float.TryParse(Console.ReadLine(), out number2))
        {
            Console.WriteLine(" Incorrect number format");
        }
        Console.WriteLine("Number {0} is greater than {1} ", Math.Max(number1, number2),
            ((number1 + number2) - Math.Max(number1, number2)));
    }
}
