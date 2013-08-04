//Write a program to convert hexadecimal numbers to binary numbers (directly).

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
        Console.Write("Please enter a hexadecimal number to be converted into binary numeral system: ");
        string hexadecimalNumber = Console.ReadLine();
        StringBuilder binaryNumber = new StringBuilder();
        for (int i = 0; i < hexadecimalNumber.Length; i++)
        {
            binaryNumber.Append(GetBinaryString(hexadecimalNumber[i]));
        }

        Console.WriteLine("The binary representation is: {0}", binaryNumber);
    }

    private static string GetBinaryString(char ch)
    {
        switch (ch)
        {
            case '0':
                return "0000";
            case '1':
                return "0001";
            case '2':
                return "0010";
            case '3':
                return "0011";
            case '4':
                return "0100";
            case '5':
                return "0101";
            case '6':
                return "0110";
            case '7':
                return "0111";
            case '8':
                return "1000";
            case '9':
                return "1001";
            case 'A':
                return "1010";
            case 'B':
                return "1011";
            case 'C':
                return "1100";
            case 'D':
                return "1101";
            case 'E':
                return "1110";
            case 'F':
                return "1111";
            default:
                return "-1";
        }
    }
}
