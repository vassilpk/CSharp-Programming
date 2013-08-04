// Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.


using System;

class IsBit3Zero
{
    static void Main()
    {
        int number;
        byte bitPosition = 3;
        int mask = 1;
        bool isBitValueOne = false;
        Console.Write("Please enter an integer number: ");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2));
        isBitValueOne = (mask & (number >> bitPosition)) == 1;
        Console.WriteLine((isBitValueOne == true) ? "The value of the bit 3 si 1." : "The value of the bit 3 si 0.");
     }
}
