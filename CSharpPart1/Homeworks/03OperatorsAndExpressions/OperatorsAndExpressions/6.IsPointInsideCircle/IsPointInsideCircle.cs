//  Write an expression that checks if given point (x,  y) is within a circle K(O, 5).


using System;

class IsPointInsideCircle
{
    static void Main()
    {
        bool isPointInside = false;
        const int radius = 5;
        float x, y;

        Console.WriteLine("Please enter the coordinates (x, y) of the point:");
        x = float.Parse(Console.ReadLine());
        y = float.Parse(Console.ReadLine());
        isPointInside = Math.Sqrt((x * x) + (y * y)) <= radius;
        Console.WriteLine("It is {0} that point ({1},{2}) is inside the circle K(0,{3}).", isPointInside, x, y, radius);
    }
}
