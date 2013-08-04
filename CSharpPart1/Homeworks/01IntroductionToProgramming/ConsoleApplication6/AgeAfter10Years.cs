using System;

class AgeAfter10Years
{
    static void Main()
    {
        int currentAge;
        Console.Write("Please enter your current age: ");
        currentAge = int.Parse(Console.ReadLine());
        Console.WriteLine("After 10 years you will be {0} years old.", currentAge += 10);
    }
}

