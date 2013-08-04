using System;

class RectanglesArea
{
    static void Main()
    {
        decimal width, height;

        Console.Write("Please enter the width of the rectangle: ");
        width = decimal.Parse(Console.ReadLine());
        Console.Write("Please enter the height of the rectangle: ");
        height = decimal.Parse(Console.ReadLine());
        Console.WriteLine("The area of the rectangle is {0}.", (width * height));
    }
}
