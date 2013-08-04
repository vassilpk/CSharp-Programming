//Write a program to convert from any numeral system of given base s to
//any other numeral system of base d (2 ≤ s, d ≤  16).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AnyToAnyNumeralSystem
{
    static void Main()
    {
        Console.SetWindowSize(120, 20);
        Console.Write("Please enter the base s (2 <= s <= 16) of the numeral system of the number that will be converted: ");
        int fromBaseS = int.Parse(Console.ReadLine());
        Console.Write("Please enter the number to be converted: ");
        string numberToConvert = Console.ReadLine();
        Console.Write("Please enter the base d (2 ≤ d ≤  16) of the numeral system to which number {0} will be converted: ",
            numberToConvert);
        int toBaseD = int.Parse(Console.ReadLine());
        int decimalNumber = 0;
        decimalNumber = ConvertToDecimal(numberToConvert, fromBaseS);
        //Console.WriteLine(decimalNumber);
        List<char> listOfChars = new List<char>();
        ConvertFromDecimal(decimalNumber, toBaseD, listOfChars);
        Console.Write("The number {0} represented in numeral system of base {1} is: ", numberToConvert, toBaseD);
        foreach (var ch in listOfChars)
        {
            Console.Write(ch);
        }
        Console.WriteLine();
    }

    private static void ConvertFromDecimal(int decimalNumber, int toBaseD, List<char> listOfChars)
    {
        while (decimalNumber > 0)
        {
            listOfChars.Add(GetCharFromInt(decimalNumber % toBaseD));
            decimalNumber /= toBaseD;
        }

        listOfChars.Reverse();
    }

    private static int ConvertToDecimal(string numberToConvert, int fromBaseS)
    {
        int decimalNumber = 0;
        for (int i = 0; i < numberToConvert.Length; i++)
        {
            decimalNumber += (GetIntFromChar((numberToConvert[(numberToConvert.Length - 1) - i]))) *
                (int)Math.Pow(fromBaseS, i);
        }

        return decimalNumber;
    }

    private static char GetCharFromInt(int remainder)
    {
        switch (remainder)
        {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
                return (char)(remainder + '0');
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
                return (char)(remainder + 55); //'A' = (char)(55 + 10); 'B' = (char)(55 + 11);........
            default:
                return 'Z';
        }
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
