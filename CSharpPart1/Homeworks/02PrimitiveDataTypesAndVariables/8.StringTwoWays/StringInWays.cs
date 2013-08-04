using System;

class StringInTwoWays
{
    static void Main()
    {
        string firstWay = "The \"use\" of quotations causes problems.";
        string secondWay = @"The ""use"" of quotations causes problems.";
        Console.WriteLine(firstWay);
        Console.WriteLine(secondWay);
    }
}

