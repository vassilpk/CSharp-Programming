using System;

class ExtractBitValue
{
    static void Main()
    {
        int number;
        byte bitPosition;
        int mask = 1;
        int bitValue;
        Console.Write("Please enter an integer number: ");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number,2));
        Console.Write("Please enter the number of the bit whose value shoud be extracted [0..31]: ");
        bitPosition = byte.Parse(Console.ReadLine());
        bitValue = mask & (number >> bitPosition);
        Console.WriteLine("The value of the bit at position {0} is {1}", bitPosition, bitValue);
     }
}
