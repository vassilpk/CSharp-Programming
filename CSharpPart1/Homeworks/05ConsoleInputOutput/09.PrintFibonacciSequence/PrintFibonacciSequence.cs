//  Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;
using System.Numerics;

    class PrintFibonacciSequence
    {
        static void Main()
        {
            BigInteger number1 = 0;
            BigInteger number2 = 1;
        
            for (int i = 0; i < 50; i++)
            {
                Console.Write("{0},{1},", number1, number2);
                number1 += number2;
                number2 += number1;
            }

        }
    }
