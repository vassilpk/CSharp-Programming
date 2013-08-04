using System;

class TrapezoidsArea
{
    static void Main()
    {
        float sideA, sideB, height;
        float area;
        Console.WriteLine("Please enter the sides and the height of the trapezoid:");
        sideA = float.Parse(Console.ReadLine());
        sideB = float.Parse(Console.ReadLine());
        height = float.Parse(Console.ReadLine());
        
        area = ((sideA + sideB) / 2) * height;
        Console.WriteLine("The area of the trapezoid is {0}", area);
    }
}
