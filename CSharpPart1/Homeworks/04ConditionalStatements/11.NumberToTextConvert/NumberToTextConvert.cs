//  * Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. 
//  Examples:
//	0  "Zero"
//	273  "Two hundred seventy three"
//	400  "Four hundred"
//	501  "Five hundred and one"
//	711  "Seven hundred and eleven"


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.NumberToTextConvert
{
    class NumberToTextConvert
    {
        static string DigitToText(int digit)
        {
            string[] digitName = {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            string digitNameText = null;

            if (digit != 0)
            {
                digitNameText = digitName[digit - 1];
            } 
            return digitNameText;
        }
        static string NumberToText20_90(int number20_90)
        {
            string[] numberName = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string numberNameText = null;

            numberNameText = numberName[number20_90 - 2];
            return numberNameText;
        }
        static string NumberToText10_19(int number10_19)
        {
            string[] numberName = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string numberNameText = null;

            numberNameText = numberName[number10_19 - 10];
            return numberNameText;
        }
        static string NumberToTextOnesTens(int number)
        {
            string numberNameText = null;
            if ((number < 20) && (number > 9))
            {
                numberNameText = NumberToText10_19(number);
            }
            else
            {
                numberNameText = NumberToText20_90(number / 10) + " " + DigitToText(number % 10);
            }
            return numberNameText;
        }
     

        static void Main()
        {
            int number;
            Console.WriteLine("Please enter a positive integer number in the interval [0..999].");
            number = int.Parse(Console.ReadLine());
            if (number > 99)
            {
                if (((number % 100) / 10) != 0)
                {
                    if (((number % 100) < 20) && ((number % 100) > 9))
                    {
                        Console.WriteLine("The number is: {0} hundred and {1}", DigitToText(number / 100),
                            NumberToTextOnesTens(number % 100));
                    }
                    else
                    {
                        Console.WriteLine("The number is: {0} hundred {1}", DigitToText(number / 100),
                           NumberToTextOnesTens(number % 100));
                    }
                }
                else if (number % 10 != 0)
                {
                    Console.WriteLine("The number is: {0} hundred and {1}", DigitToText(number / 100),
                       DigitToText(number % 10));
                }
                else
                {
                    Console.WriteLine("The number is: {0} hundred", DigitToText(number / 100));
                }
            }
            else if (number != 0)
            {
                if (number / 10 != 0)
                {
                    Console.WriteLine("The number is: {0}", NumberToTextOnesTens(number));
                }
                else
                {
                    Console.WriteLine("The number is: {0}", DigitToText(number));                       
                }
            }
            else
            {
                Console.WriteLine("The number is: zero");
            }

        }
    }
}

