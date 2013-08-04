using System;

class StringHelloWorld
{
    static void Main()
    {
        string firstString = "Hello";
        string secondString = "World";
        object concatStrings = firstString + " " + secondString;
        string thirdString = (string)concatStrings;
        Console.WriteLine("The string of the object variable is: {0}", concatStrings);
        Console.WriteLine("The string of the string variable is: {0}", thirdString);
    }
}

