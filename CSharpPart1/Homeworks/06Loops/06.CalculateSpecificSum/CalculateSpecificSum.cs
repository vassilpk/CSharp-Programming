using System;

class CalculateSpecificSum
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
        int N, X; 
        double expressionResult = 1;

        Console.WriteLine("Please enter an integer number N");
        while ((!int.TryParse(Console.ReadLine(), out N)) || (N < 1))
        {
            Console.WriteLine(" Incorrect number format");
        }

        Console.WriteLine("Please enter an integer number X");
        while (!int.TryParse(Console.ReadLine(), out X) || (X <= 1))
        {
            Console.WriteLine(" Incorrect number format");
        }
        for (int i = 1; i <= N; i++)
        {
            expressionResult += CalculateFactorial(i) / Math.Pow(X, i);     
        }
       
        Console.WriteLine("S = 1 + 1!/X + 2!/X^2 + … + N!/X^N = {0}", expressionResult);

    }
}

