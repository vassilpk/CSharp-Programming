using System;

class PutValue
{
    static void Main()
    {
        int number;
        byte valueToSet = 1;
        byte bitPosition;
        int mask = 1;

        Console.Write("Please enter an integer number: ");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2));
        Console.Write("Please enter the value to be set [0 or 1]: ");
        valueToSet = byte.Parse(Console.ReadLine());
        Console.Write("Please enter the number of the bit whose value shoud be set to {0}: ", valueToSet);
        bitPosition = byte.Parse(Console.ReadLine());
        number = number & (~(mask << bitPosition));
        number = number | (valueToSet << bitPosition);
        Console.WriteLine(Convert.ToString(number,2));
    }
}
