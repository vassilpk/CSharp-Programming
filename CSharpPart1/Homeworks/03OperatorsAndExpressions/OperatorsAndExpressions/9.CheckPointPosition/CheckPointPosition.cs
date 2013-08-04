/*  Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) 
    and out of the rectangle R(top=1, left=-1, width=6, height=2). */


using System;

class CheckPointPosition
{
    static void Main()
    {
        bool isInsideCircle;
        bool isInsideRectangle = false;
        const int radius = 3;
        const int centerX = 1;
        const int centerY = 1;
        const int rectangleTopLeftX = -1;
        const int rectangleTopLeftY = 1;
        const int rectangleBottomRightX = 5;
        const int rectangleBottomRightY = -1;
        float x, y;

        Console.WriteLine("Please enter the coordinates (x, y) of the point:");
        x = float.Parse(Console.ReadLine());
        y = float.Parse(Console.ReadLine());
        isInsideCircle = Math.Sqrt(Math.Pow((x-centerX),2) + Math.Pow((y-centerY),2)) <= radius;
        isInsideRectangle = ((x > rectangleTopLeftX) && (x < rectangleBottomRightX)) &&
            ((y < rectangleTopLeftY) && (y > rectangleBottomRightY));
        
        Console.WriteLine("The point ({0},{1}) is inside the circle: {2}", x, y, isInsideCircle);
        Console.WriteLine("The point ({0},{1}) is inside the rectangle: {2}", x, y, isInsideRectangle);
    }
}
