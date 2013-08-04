using System;

class PrintNNumbers
{
    static void Main()
    {
        int range;
       
        Console.WriteLine("Please enter an integer number N: ");

        while (!int.TryParse(Console.ReadLine(), out range))
        {
            Console.WriteLine(" Incorrect number format");
        }
        for (int i = 1; i <= range; i++)
        {
            Console.WriteLine(i);
        }
    }
}