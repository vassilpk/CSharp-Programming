//  Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class CalculateSumWithAccuracy
{
    static void Main()
    {
        decimal sum = 1m;

        for (int i = 2; i <= 1000; i +=2)
        {
            sum = sum + (decimal)(1.0 / i) - (decimal)(1.0 / (i + 1));
        }
        Console.WriteLine("{0}",sum);
    }
}
