using System;

class ExchangeBits
{
    static void Main()
    {
        byte firstBitSeq1 = 3; 
        byte firstBitSeq2 = 24;  
        byte sequenceLength = 3; //According to the problem bits 3, 4, 5 have to be exchanged with bits 24, 25, 26
        uint sourceNumber = 65535;
        uint mask = 1;
        uint tempNumber;
        uint resultNumber;
        Console.SetWindowSize(120, 30); 
        Console.WriteLine("{0} is the number whose bits 3, 4, 5 will be exchanged with bits 24, 25, 26.",
            Convert.ToString(sourceNumber, 2).PadLeft(32, '0'));
        tempNumber = (((sourceNumber >> firstBitSeq1) ^ (sourceNumber >> firstBitSeq2)) & ((mask << sequenceLength)-1));
        resultNumber = (((tempNumber << firstBitSeq1) | (tempNumber << firstBitSeq2)) ^ sourceNumber);
        Console.WriteLine("{0} is the number after the exchange of the bits.", 
        Convert.ToString(resultNumber, 2).PadLeft(32, '0'));        
   }
}
