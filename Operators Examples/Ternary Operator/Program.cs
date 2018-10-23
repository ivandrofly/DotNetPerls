using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(GetValue("Sam"));
        Console.WriteLine(GetValue("Jane"));
    }

    /// <summary>
    /// Return the value 100 if the name matches, otherwise -1.
    /// </summary>
    static int GetValue(string name)
    {
        return name == "Sam" ? 100 : -1;
    }
}

//Output

//100
//-1