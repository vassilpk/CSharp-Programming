using System;
using System.Threading;
using System.Globalization;

class Program
{
    static void Main()
    {
        float radius;

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Please enter the radius of the circle: ");
        radius = float.Parse(Console.ReadLine());
        Console.WriteLine("The perimeter of the circle is {0}", 2 * Math.PI * radius);
    }
}
