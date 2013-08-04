//Write a program that, depending on the user's choice inputs int, double or string variable. 
//  If the variable is integer or double, increases it with 1. If the variable is string, 
//  appends "*" at its end. The program must show the value of that variable as a console output.
//  Use switch statement.


using System;

class UsersChoiceInput
{
    static void Main()
    {
        string inputType = "";
        string input = "";
        int intNumber = 0;
        double doubleNumber = 0;
        Console.WriteLine("Please enter an integer, double or string");
        input = Console.ReadLine();
        
        if (int.TryParse(input, out intNumber))
        {
            inputType = "integer";
        }
        else if (double.TryParse(input, out doubleNumber))
        {
            inputType = "double";
        }
        
        switch (inputType)
        {
            case "integer": 
                Console.WriteLine("You have entered an integer type number which increased with 1 is {0}.",
                    intNumber + 1);
                break;
            case "double":
                Console.WriteLine("You have entered a double type number which increased with 1 is {0}.",
                    doubleNumber + 1);
                break;
            default:
                Console.WriteLine("You have entered a string which appended with '*' at the end is {0}.",
                    input + '*');
                break;
        }
    }
}
