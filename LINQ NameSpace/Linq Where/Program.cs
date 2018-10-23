using System;
using System.Linq;

class Program
{
    static void Main()
    {
        //
        // Example array that contains unwanted null and empty strings.
        //
        string[] array = { "dot", "", "net", null, null, "perls", null };
        //
        // Use Where method to remove null strings.
        //
        var result1 = array.Where(item => item != null);
        foreach (string value in result1)
        {
            Console.WriteLine("Not Null: {0}", value);
        }

        Console.WriteLine();
        //
        // Use Where method to remove null and empty strings.
        //
        var result2 = array.Where(item => !string.IsNullOrEmpty(item));
        foreach (string value in result2)
        {
            Console.WriteLine("Not Empty and Null: {0}", value);
        }
    }
}

//Output

//dot         -- Begins output from first loop
//        -- Empty string included
//net
//perls
//dot         -- Begins output from second loop
//net
//perls