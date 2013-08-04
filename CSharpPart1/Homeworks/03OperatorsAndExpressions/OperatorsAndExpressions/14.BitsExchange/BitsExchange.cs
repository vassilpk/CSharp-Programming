// * Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} 
// of given 32-bit unsigned integer.


using System;

class BitsExchange
{
    static void Main()
    {
        byte bitPositionSeq1 = 5; // This is "p" according to the problrm
        byte bitPositionSeq2 = 19; // This is "q" according to the problem 
        byte sequenceLength;
        uint sourceNumber;
        uint mask = 1;
        uint tempNumber;
        uint resultNumber;
        Console.Write("Please enter an integer number:");
        sourceNumber = uint.Parse(Console.ReadLine());
        Console.WriteLine("{0} is the number whose bits will be swaped.", Convert.ToString(sourceNumber, 2).PadLeft(32, '0'));
        Console.Write("How many bits should be swaped:");
        sequenceLength = byte.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the numbers of the first bits in the sequences to be swaped:");
        bitPositionSeq1 = byte.Parse(Console.ReadLine());
        bitPositionSeq2 = byte.Parse(Console.ReadLine());

        tempNumber = (((sourceNumber >> bitPositionSeq1) ^ (sourceNumber >> bitPositionSeq2)) &
            ((mask << sequenceLength) - 1));
        resultNumber = (sourceNumber ^ ((tempNumber << bitPositionSeq1) | (tempNumber << bitPositionSeq2)));
        Console.WriteLine("{0} is the result of the swap.", Convert.ToString(resultNumber, 2).PadLeft(32, '0'));
    }
}
