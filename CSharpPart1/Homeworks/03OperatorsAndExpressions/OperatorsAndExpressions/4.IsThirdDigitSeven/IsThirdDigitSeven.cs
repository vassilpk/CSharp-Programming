// Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.


using System;

class IsThirdDigitSeven
{
    static void Main()
    {
        bool isThirdDigit7 = false;
        int number;
        Console.WindowWidth = 90;
        Console.Write("Please enter an integer number whose third digit shoul be checked for beeng 7: ");
        number = int.Parse(Console.ReadLine());
        isThirdDigit7 = ((number % 1000) / 700) == 1;
        Console.WriteLine("It is {0} that the third digit of number {1} is 7.", isThirdDigit7, number);
    }
}
