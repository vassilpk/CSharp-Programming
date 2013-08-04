using System;
using System.Numerics;

class FibonacciMembers
{
    static void Main()
    {
        BigInteger number1 = 0;
        BigInteger number2 = 1;
        int N;

        Console.WriteLine("Please enter an integer number N ");
        while ((!int.TryParse(Console.ReadLine(), out N)) || (N < 1))
        {
            Console.WriteLine(" Incorrect number format");
        }

        for (int i = 1; i <= ((N / 2) + (N % 2)); i++)
        {
            if (i == ((N / 2) + (N % 2)) && ((N % 2) != 0))
            {
                Console.Write("{0}", number1);
            }
            else
            {
                Console.Write("{0},{1},", number1, number2);
            }
            
            number1 += number2;
            number2 += number1;
        }
    }
}

