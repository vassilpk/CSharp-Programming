using System;

class ReadThreeIntegers
{
    static void Main()
    {
        int a, b, c;

        Console.WriteLine("Please enter the integer numbers a, b, c :");
        a= int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        Console.WriteLine("The sum of a={0}, b={1}, c={2} is {3}", a, b, c, a+b+c);
    }
}
