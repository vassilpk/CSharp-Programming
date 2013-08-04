using System;

class CompareNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        bool compare = (Math.Abs(firstNumber-secondNumber) < 0.000001m);
        Console.WriteLine(compare);
    }
}
