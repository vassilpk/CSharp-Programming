using System;

class MembersOfSequence
{
    static void Main()
    {
        for (int i=2; i <= 11; i++)
        {
            Console.Write(i % 2 == 0 ? "{0} " : "-{0} ", i); 
        }
        Console.WriteLine();
    }
}

