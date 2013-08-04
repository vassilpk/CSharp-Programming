using System;

class VariablesExchange
{
    static void Main()
    {
        int firstVar = 5;
        int secondVar = 10;
        int swapVar;
        Console.WriteLine("First variable = {0}, Second variable = {1}", firstVar, secondVar);
        swapVar = firstVar;
        firstVar = secondVar;
        secondVar = swapVar;
        Console.WriteLine("First variable = {0}, Second variable = {1}", firstVar, secondVar);
    }
}
