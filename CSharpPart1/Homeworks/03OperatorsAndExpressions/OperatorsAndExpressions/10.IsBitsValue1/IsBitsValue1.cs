/*Write a boolean expression that returns if the bit at position p (counting from 0) 
in a given integer number v has value of 1. Example: v=5; p=1  false. */


using System;

class IsBitsValue1
{
    static void Main()
    {
        int number;
        byte bitPosition;
        int mask = 1;
        bool isBitValueOne = false;
        Console.Write("Please enter an integer number: ");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2));
        Console.Write("Please enter the number of the bit whose value shoud be checked: ");
        bitPosition = byte.Parse(Console.ReadLine());
        isBitValueOne = (mask & (number >> bitPosition)) == 1;
        Console.WriteLine("It is {0} that the value of the bit at position {1} is 1.", isBitValueOne, bitPosition);
    }
}
