//  Write a program that finds the greatest of given 5 variables.


using System;

class GreatestOfFiveVariables
{
    static void Main()
    {
        int[] variables = new int[5];
        int greatestVariable;
        for (int i = 0; i < 5; i++)
		{
			while (!int.TryParse(Console.ReadLine(), out variables[i]))
            {
                Console.WriteLine(" Incorrect number format");
            }
		}
        Array.Sort(variables);
        greatestVariable = variables[variables.Length - 1];
        Console.WriteLine("The greatest value of the entered variables is {0}", greatestVariable);
    }
}
