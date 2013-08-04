using System;

class CalculateExpression
{
    static int CalculateFactorial(int factorialRange)
    {
        int factorial = 1;

        for (int i = factorialRange; i > 1; i--)
        {
            factorial *= i; 
        }
        return factorial;
    }

    static void Main()
    {
        int N, K;

        Console.WriteLine("Please enter an integer number N greater than 1");
        while ((!int.TryParse(Console.ReadLine(), out N)) || (N <= 1))
        {
            Console.WriteLine(" Incorrect number format");
        }

        Console.WriteLine("Please enter an integer number K greater than 1 and smaller than N");
        while (!int.TryParse(Console.ReadLine(), out K) || (K <= 1) || (K >= N))
        {
            Console.WriteLine(" Incorrect number format");
        }
        Console.WriteLine("N!/K!={0}", (CalculateFactorial(N) / CalculateFactorial(K)));
    }
}
