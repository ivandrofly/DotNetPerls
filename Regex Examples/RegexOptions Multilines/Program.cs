using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Input string.
        const string example = @"This string
has two lines";

        // Get a collection of matches with the Multiline option.
        MatchCollection matches = Regex.Matches(example, "^(.+)$", RegexOptions.Multiline);
        foreach (Match match in matches)
        {
            // Loop through captures.
            foreach (Capture capture in match.Captures)
            {
                // Display them.
                Console.WriteLine("--" + capture.Value);
            }
        }
    }

}

//Output

//--This string
//--has two lines