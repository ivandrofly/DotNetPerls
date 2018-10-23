
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Input array.
        string[] array = { "the", "glass", "bead", "game" };

        // Order alphabetically by reversed strings.
        var result = array.OrderBy(a => new string(a.ToCharArray().Reverse().ToArray()));

        // Display results.
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}

//Output

//bead
//the
//game
//glass