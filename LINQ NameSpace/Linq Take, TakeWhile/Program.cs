using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> list = new List<string>();
        list.Add("cat");
        list.Add("dog");
        list.Add("programmer");

        // Get first 2 elements
        var first = list.Take(2);
        foreach (string s in first)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine();

        // Get last 2 elements reversed
        var last = list.Reverse<string>().Take(2);
        foreach (string s in last)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine();

        // Get first 1000 elements
        var all = list.Take(1000);
        foreach (string s in all)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine();
    }
}

//Output

//cat
//dog

//programmer
//dog

//cat
//dog
//programmer