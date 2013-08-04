//Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.SetWindowSize(100, 20);
        Console.Write("Please enter a hexadecimal number to be converted into decimal numeral system: ");
        string hexadecimalNumber = Console.ReadLine();
        int decimalNumber = 0;
        for (int i = 0; i < hexadecimalNumber.Length; i++)
        {
            decimalNumber += (GetIntFromChar((hexadecimalNumber[(hexadecimalNumber.Length - 1) - i]))) *
                (int)Math.Pow(16, i);
        }

        Console.WriteLine("The decimal representation is: {0}", decimalNumber);
    }

    private static int GetIntFromChar(char ch)
    {
        switch (ch)
        {
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
                return (ch - '0');
            case 'A':
            case 'B':
            case 'C':
            case 'D':
            case 'E':
            case 'F':
                return (ch - 55); //10 = 'A' - 55 = 65 - 10 ...
            default:
                return -1;
        }
    }
}
