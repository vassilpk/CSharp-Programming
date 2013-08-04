////Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalToBinary
{
    static void Main()
    {
        Console.SetWindowSize(100, 20);
        Console.Write("Please enter a positive integer number to be converted into binary numeral system: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        List<byte> listOfBits = new List<byte>();
        Console.Write("The binary representation of number {0} is: ", decimalNumber);
        while (decimalNumber > 0)
        {
            listOfBits.Add((byte)(decimalNumber % 2));
            decimalNumber /= 2;
        }

        listOfBits.Reverse();
        foreach (var bit in listOfBits)
        {
            Console.Write(bit);
        }

        Console.WriteLine();
    }
}