//  Sort 3 real values in descending order using nested if statements.


using System;

    class SortInDescendingOrder
    {
        static void Main()
        {
            int[] numbers = {0, 0, 0};

            Console.WriteLine("Please enter three integer numbers: ");

            while (!int.TryParse(Console.ReadLine(), out numbers[0]))
            {
                Console.WriteLine(" Incorrect number format");
            }
            while (!int.TryParse(Console.ReadLine(), out numbers[1]))
            {
                Console.WriteLine(" Incorrect number format");
            }
            while (!int.TryParse(Console.ReadLine(), out numbers[2]))
            {
                Console.WriteLine(" Incorrect number format");
            }

            if ((numbers[0] >= numbers[1]) && (numbers[0] >= numbers[2]))
            {
                if (numbers[2] >= numbers[1])
                {
                    numbers[2] = numbers[1] + numbers[2];
                    numbers[1] = numbers[2] - numbers[1];
                    numbers[2] = numbers[2] - numbers[1];
                }
            }
            else if ((numbers[1] >= numbers[0]) && (numbers[1] >= numbers[2]))
            {
                numbers[1] = numbers[0] + numbers[1];
                numbers[0] = numbers[1] - numbers[0];
                numbers[1] = numbers[1] - numbers[0];

                if (numbers[2] >= numbers[1])
                {
                    numbers[2] = numbers[1] + numbers[2];
                    numbers[1] = numbers[2] - numbers[1];
                    numbers[2] = numbers[2] - numbers[1];
                }
            }
            else
            {
                numbers[2] = numbers[0] + numbers[2];
                numbers[0] = numbers[2] - numbers[0];
                numbers[2] = numbers[2] - numbers[0];

                if (numbers[2] >= numbers[1])
                {
                    numbers[2] = numbers[1] + numbers[2];
                    numbers[1] = numbers[2] - numbers[1];
                    numbers[2] = numbers[2] - numbers[1];
                }

            }
            Console.WriteLine("The biggest of {0}, {1}, {2} .", numbers[0], numbers[1], numbers[2]);
        }
    }
