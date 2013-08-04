//  Write an if statement that examines two integer variables and exchanges their 
//  values if the first one is greater than the second one.

using System;

    class CompareAndExchangeVariables
    {
        static void Main()
        {
            int number1, number2;
            bool isExchanced = false;

            Console.WriteLine("Please enter two integer numbers: ");

            while (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine(" Incorrect number format");
            }

            while (!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine(" Incorrect number format");
            }
            if (number1 > number2)
            {
                number1 = number1 + number2;
                number2 = number1 - number2;
                number1 = number1 - number2;
                isExchanced = true;
            }
            if (isExchanced == true)
            {
                Console.WriteLine("\nThe values of number1 and number2 are exchanged!\n");    
            }

            Console.WriteLine("Number1 = {0}", number1);
            Console.WriteLine("Number2 = {0}", number2);
        }
    }
