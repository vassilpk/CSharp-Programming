using System;

class PrintNSpecificNumbers
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
            if ((i % 3 != 0) && (i % 7 != 0))
            {
                Console.Write(i != range ? "{0}, " : "{0}", i); 
            }
        }
    }
}

