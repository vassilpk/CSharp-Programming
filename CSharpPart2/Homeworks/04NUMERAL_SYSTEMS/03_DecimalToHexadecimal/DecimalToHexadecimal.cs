////Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.SetWindowSize(100, 20);
        Console.Write("Please enter a positive integer number to be converted into hexadecimal numeral system: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        List<char> listOfChars = new List<char>();
        Console.Write("The hexadecimal representation of number {0} is: ", decimalNumber);
        while (decimalNumber > 0)
        {
            listOfChars.Add(GetChar(decimalNumber % 16));
            decimalNumber /= 16;
        }

        listOfChars.Reverse();
        foreach (var ch in listOfChars)
        {
            Console.Write(ch);
        }
    }

    private static char GetChar(int remainder)
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
}
