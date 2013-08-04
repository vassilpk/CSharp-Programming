////Write a program to convert binary numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryToDecimal
{
    static void Main()
    {
        Console.SetWindowSize(100, 20);
        Console.Write("Please enter a binary number to be converted into decimal numeral system: ");
        string binaryNumber = Console.ReadLine();
        int decimalNumber = 0;
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            decimalNumber += ((binaryNumber[(binaryNumber.Length - 1) - i]) - 48) * (int)Math.Pow(2, i); //'0' = 48
        }

        Console.WriteLine("The decimal representation is: {0}", decimalNumber);
    }
}