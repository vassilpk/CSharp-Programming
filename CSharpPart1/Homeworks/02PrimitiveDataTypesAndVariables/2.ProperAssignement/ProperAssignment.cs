using System;

class ProperAssignment
{
    static void Main()
    {
        double number1 = 34.567839023;
        float number2 = 12.345f;
        double number3 = 8923.1234857;
        float number4 = 3456.091f;
        
        Console.WriteLine("Number {0} is of type {1}", number1, number1.GetTypeCode());
        Console.WriteLine("Number {0} is of type {1}", number2, number2.GetTypeCode());
        Console.WriteLine("Number {0} is of type {1}", number3, number3.GetTypeCode());
        Console.WriteLine("Number {0} is of type {1}", number4, number4.GetTypeCode());
    }
}

