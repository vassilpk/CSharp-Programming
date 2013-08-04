using System;

class DeclarationOfFiveVariables
{
    static void Main()
    {
        ushort number1 = 52130;
        sbyte number2 = -115;
        int number3 = 4825932;
        byte number4 = 97;
        short number5 = -10000;
 
        Console.WriteLine("Number {0} is of type {1}", number1, number1.GetTypeCode());
        Console.WriteLine("Number {0} is of type {1}", number2, number2.GetTypeCode());
        Console.WriteLine("Number {0} is of type {1}", number3, number3.GetTypeCode());
        Console.WriteLine("Number {0} is of type {1}", number4, number4.GetTypeCode());
        Console.WriteLine("Number {0} is of type {1}", number5, number5.GetTypeCode());
    }
}
