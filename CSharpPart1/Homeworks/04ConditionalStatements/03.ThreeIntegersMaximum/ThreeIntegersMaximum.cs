//  Write a program that finds the biggest of three integers using nested if statements.

using System;

class ThreeIntegersMaximum
{
    static void Main(string[] args)
    {
        int a, b, c;
        int maxValue;
       
        Console.WriteLine("Please enter three integer numbers: ");

        while (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine(" Incorrect number format");
        }
        while (!int.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine(" Incorrect number format");
        }
        while (!int.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine(" Incorrect number format");
        }
        
        if ((a >= b) && (a >= c))
        {
            maxValue = a;
        }
        else if (( b>= a) && ( b >= c ))
        {
            maxValue = b;
        }
        else
        {
            maxValue = c;
        }
        Console.WriteLine("The biggest of {0}, {1}, {2} is {3}.", a, b, c, maxValue);
    }
}
