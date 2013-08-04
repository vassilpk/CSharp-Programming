//  Write a program that applies bonus scores to given scores in the range [1..9]. 
//  The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10;
//  if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000. 
//  If it is zero or if the value is not a digit, the program must report an error.
//  Use a switch statement and at the end print the calculated new value in the console.

using System;

class BonusScores
{
    static void Main()
    {
        int score;
        Console.WriteLine("Please enter the score in the range [1..9].");
        while (!int.TryParse(Console.ReadLine(), out score) || (score < 1) || (score > 9))
            {
                Console.WriteLine("You have not entered a digit in the range [1..9]");
            }
        switch (score)
        {
            case 1:
            case 2:
            case 3:
                score *= 10;
                break;
            case 4:
            case 5:
            case 6:
                score *= 100;
                break;
            case 7:
            case 8:
            case 9:
                score *= 1000;
                break;
            default:
                break;
        }
        Console.WriteLine("According to the entered digit the new value is: {0}", score);
    }
}
