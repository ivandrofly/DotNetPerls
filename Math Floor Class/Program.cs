//Program that uses Math.Floor: C#

using System;

class Program
{
    static void Main()
    {
        //
        // Two values.
        //
        double value1 = 123.456;
        double value2 = 123.987;
        //
        // Take floors of these values.
        //
        double floor1 = Math.Floor(value1);
        double floor2 = Math.Floor(value2);

        //
        // Write first value and floor.
        //
        Console.WriteLine(value1);
        Console.WriteLine(floor1);
        //
        // Write second value and floor.
        //
        Console.WriteLine(value2);
        Console.WriteLine(floor2);
    }
}

//Output

//123.456
//123     [floor]
//123.987
//123     [floor]