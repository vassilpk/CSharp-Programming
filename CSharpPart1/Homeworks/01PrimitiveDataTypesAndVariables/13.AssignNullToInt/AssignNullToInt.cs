using System;

class AssignNullToInt
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine("The variables \"a\" and \"b\" are assigned with null: a={0}, b={1}", a, b);
        a += null;
        b += 12345678;
        Console.WriteLine("The result after sumation: a={0}, b={1}", a, b);
    }
}

