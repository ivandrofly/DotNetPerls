//Program that uses enums: C#

using System;

class Program
{
    enum Importance
    {
        None,
        Trivial,
        Regular,
        Important,
        Critical
    };

    static void Main()
    {
        // ... An enum local variable.
        Importance value = Importance.Critical;

        // ... Test against known Importance values.
        if (value == Importance.Trivial)
        {
            Console.WriteLine("Not true");
        }
        else if (value == Importance.Critical)
        {
            Console.WriteLine("True");
        }
    }
}

//Output

//True