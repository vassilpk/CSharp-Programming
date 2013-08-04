using System;

class MinMaxOfNNumbers
{
    static void Main(string[] args)
    {
        int numbersQuantity;

        while (!int.TryParse(Console.ReadLine(), out numbersQuantity))
        {
            Console.WriteLine(" Incorrect number format");
        }
        
        int[] numbers = new int[numbersQuantity];

        for (int i = 0; i < numbersQuantity; i++)
        {
            while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.WriteLine(" Incorrect number format");
            }
        }
        Array.Sort(numbers);
        Console.WriteLine("The minimal value of the entered numbers is {0}", numbers[0]);
        Console.WriteLine("The maximal value of the entered numbers is {0}", numbers[numbers.Length - 1]);
    }
}

