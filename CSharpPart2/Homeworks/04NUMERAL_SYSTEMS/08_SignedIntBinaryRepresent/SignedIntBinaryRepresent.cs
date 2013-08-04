//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SignedIntBinaryRepresent
{
    static void Main()
    {
        Console.SetWindowSize(100, 20);
        Console.Write("Please enter a number of type short [-32768..32767 ]: ");
        short decimalNumber = short.Parse(Console.ReadLine());
        int[] arrayOfBits = new int[16];
        //List<byte> listOfBits = new List<byte>();
        if (decimalNumber >= 0)
        {
            ConvertDecimalToBinary(decimalNumber, arrayOfBits);
        }
        else
        {
            arrayOfBits[0] = 1;
            ConvertDecimalToBinary(decimalNumber + 32768, arrayOfBits);
        }

        Console.Write("The binary representation of number {0} is: ", decimalNumber);
        foreach (var bit in arrayOfBits)
        {
            Console.Write(bit);
        }
     
        Console.WriteLine();
    }

    private static void ConvertDecimalToBinary(int decimalNumber, int[] arrayOfBits)
    {
        int bitCounter = 15;
        while (decimalNumber > 0)
        {
            arrayOfBits[bitCounter] = decimalNumber % 2;
            decimalNumber /= 2;
            bitCounter--;
        }
    }
}