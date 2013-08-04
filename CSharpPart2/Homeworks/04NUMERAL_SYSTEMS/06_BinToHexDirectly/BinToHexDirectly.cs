//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.SetWindowSize(100, 20);
        Console.Write("Please enter a binary number to be converted into hexadecimal numeral system: ");
        string binaryNumber = Console.ReadLine();
        StringBuilder hexadecimalNumber = new StringBuilder();
        if ((binaryNumber.Length % 4) != 0)
        {
            binaryNumber = new String('0', 4 - (binaryNumber.Length % 4)) + binaryNumber;
        }

        for (int i = 0; i <= binaryNumber.Length - 4; i += 4)
        {
            hexadecimalNumber.Append(GetHexChar(binaryNumber.Substring(i, 4)));
        }

        Console.WriteLine("The hexadecimal representation is: {0}", hexadecimalNumber);
    }

    private static char GetHexChar(string binString)
    {
        switch (binString)
        {
            case "0000":
                return '0';
            case "0001":
                return '1';
            case "0010":
                return '2';
            case "0011":
                return '3';
            case "0100":
                return '4';
            case "0101":
                return '5';
            case "0110":
                return '6';
            case "0111":
                return '7';
            case "1000":
                return '8';
            case "1001":
                return '9';
            case "1010":
                return 'A';
            case "1011":
                return 'B';
            case "1100":
                return 'C';
            case "1101":
                return 'D';
            case "1110":
                return 'E';
            case "1111":
                return 'F';
            default:
                return 'Z';
        }
    }
}