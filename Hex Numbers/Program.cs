using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int value1 = 10995;

        // Write number in hex format.
        Console.WriteLine("{0:x}", value1);
        Console.WriteLine("{0:x8}", value1);

        Console.WriteLine("{0:X}", value1);
        Console.WriteLine("{0:X8}", value1);

        // Convert to hex.
        string hex = value1.ToString("X8");

        // Convert from hex to integer.
        int value2 = int.Parse(hex, NumberStyles.AllowHexSpecifier);
        Console.WriteLine(value1 == value2);
    }
}

//Output

//2af3
//00002af3
//2AF3
//00002AF3
//True