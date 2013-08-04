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
        int N, K, expressionResult;

        Console.WriteLine("Please enter an integer number K greater than 1");
        while ((!int.TryParse(Console.ReadLine(), out K)) || (K <= 1))
        {
            Console.WriteLine(" Incorrect number format");
        }

        Console.WriteLine("Please enter an integer number N greater than 1 and smaller than K");
        while (!int.TryParse(Console.ReadLine(), out N) || (N <= 1) || (N >= K))
        {
            Console.WriteLine(" Incorrect number format");
        }
        expressionResult = (CalculateFactorial(N) * CalculateFactorial(K)) / CalculateFactorial(K - N);
        Console.WriteLine("N!*K!/(K-N)!={0}", expressionResult);
    }
}

