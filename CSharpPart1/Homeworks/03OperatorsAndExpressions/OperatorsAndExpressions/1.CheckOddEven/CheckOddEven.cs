using System;

class CheckOddEven
{
    static void Main()
    {
        int number;
        Console.Write("Please enter an integer number:");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine((number % 2) == 0 ? "The number {0} is even. " : "The number {0} is odd.", number );
    }
}
