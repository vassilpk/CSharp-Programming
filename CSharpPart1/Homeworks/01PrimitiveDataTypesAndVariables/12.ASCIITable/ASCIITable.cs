using System;

class ASCIITable
{
    static void Main()
    {
        for (int symbol = 0; symbol < 256; symbol++)
        {
            Console.Write((char)symbol);
        }

    }
}

