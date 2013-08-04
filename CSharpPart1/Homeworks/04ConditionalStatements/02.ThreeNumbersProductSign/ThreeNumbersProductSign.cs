//  Write a program that shows the sign (+ or -) of the product of three real numbers 
//  without calculating it. Use a sequence of if statements.

using System;

    class ThreeNumbersProductSign
    {
        static void Main()
        {
            int a, b, c;
            bool isProductPositive = true;

            Console.WriteLine("Please enter three integer numbers: ");

            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine(" Incorrect number format");
            }
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine(" Incorrect number format");
            }
            while (!int.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine(" Incorrect number format");
            }
            if (a < 0)
            {
                isProductPositive = !isProductPositive; 
            }
            if (b < 0)
            {
                isProductPositive = !isProductPositive;
            }
            if (c < 0)
            {
                isProductPositive = !isProductPositive;
            }
            Console.WriteLine(isProductPositive == true ? "The product of ({0} * {1} * {2}) is positive." : 
                "The product of ({0} * {1} * {2}) is negative.", a, b, c);
        }
    }
