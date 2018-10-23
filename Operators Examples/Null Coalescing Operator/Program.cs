using System;

internal class Program
{
    private static string _name;

    /// <summary>
    /// Property with custom value when null.
    /// </summary>
    private static string Name { get { return _name ?? "Default"; } set { _name = value; } }

    private static void Main()
    {
        Console.WriteLine(Name);
        Name = "Perls";
        Console.WriteLine(Name);
        Name = null;
        Console.WriteLine(Name);
    }
}

//Output

//Default
//Perls
//Default