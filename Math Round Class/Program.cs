//Program that uses Math.Round: C#

using System;

class Program
{
    static void Main()
    {
        //
        // Round double type in three ways.
        //
        double before1 = 123.45;
        double after1 = Math.Round(before1, 1, MidpointRounding.AwayFromZero); // Rounds "up"
        double after2 = Math.Round(before1, 1, MidpointRounding.ToEven); // Rounds to even
        double after3 = Math.Round(before1);

        Console.WriteLine(before1); // Original
        Console.WriteLine(after1);
        Console.WriteLine(after2);
        Console.WriteLine(after3);

        //
        // Round decimal type.
        //
        decimal before2 = 125.101M;
        decimal after4 = Math.Round(before2);
        decimal after5 = Math.Round(before2, 1);

        Console.WriteLine(before2); // Original
        Console.WriteLine(after4);
        Console.WriteLine(after5);
    }
}

//Output

//123.45
//123.5  <-- MidpointRounding.AwayFromZero
//123.4  <-- MidpointRounding.ToEven
//123

//125.101
//125
//125.1