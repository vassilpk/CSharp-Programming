using System;

    class QuadraticEquationRoots
    {
        static void Main()
        {
            double a, b, c;
            double discriminant;

            Console.WriteLine("Please enter the coefficients a,b,c of the quadratic equation ax^2+bx+c=0");

            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine(" Incorrect number format");
            }

            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine(" Incorrect number format");
            }

            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine(" Incorrect number format");
            }

            discriminant = b * b - (4 * a * c);
            if (discriminant == 0)
            {
                Console.WriteLine("The equation has only one root: X={0}", -b / (2 *a));
            }
            else if (discriminant > 0)
            {
                Console.WriteLine("The equation has two roots X1={0} and X2={1}",
                    (-b + Math.Sqrt(discriminant)) / (2 * a), (-b - Math.Sqrt(discriminant)) / (2 * a));
            }
            else
            {
                Console.WriteLine("The equation has no real roots");
            }
           
        }
    }
