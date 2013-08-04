using System;

class IsDivisionPossible
{
    static void Main()
    {
        bool isDivisionPossible = false;
        int number;
        Console.Write("Please enter an integer number to be checked:");
        number = int.Parse(Console.ReadLine());
        isDivisionPossible = ((number % 5) == 0) && ((number % 7) == 0);
        Console.WriteLine("It is {0} that {1} can be divided by 5 and 7 in the same time, without reminder.", 
            isDivisionPossible, number); 
    }
}
