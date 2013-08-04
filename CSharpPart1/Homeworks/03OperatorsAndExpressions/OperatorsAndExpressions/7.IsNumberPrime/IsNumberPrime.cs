//  Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.


using System;

class IsNumberPrime
{
    static void Main()
    {
        byte number;
        bool isPrime = true;
        byte i = 2;

        Console.Write("Please enter an integer number [1..100]: ");
        number = byte.Parse(Console.ReadLine());
        while (((number % i) == 0) && (i < 10))
        {
            isPrime = false;
            i++;
        }
        Console.WriteLine("It is {0} that number {1} is prime.", isPrime, number);

    }
}

