
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Input string.
        const string value = @"said shed see spear spread super";

        // Get a collection of matches.
        MatchCollection matches = Regex.Matches(value, @"s\w+d");

        // Use foreach loop.
        foreach (Match match in matches)
        {
            foreach (Capture capture in match.Captures)
            {
                Console.WriteLine("Index={0}, Value={1}", capture.Index, capture.Value);
            }
        }
    }
}


//Output

//Index=0, Value=said
//Index=5, Value=shed
//Index=20, Value=spread