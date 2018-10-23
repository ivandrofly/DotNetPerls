
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
	// A
	// The input string we are using
	string input = "OneTwoThree";

	// B
	// The regular expression we use to match
	Regex r1 = new Regex(@"One([A-Za-z0-9\-]+)Three");

	// C
	// Match the input and write results
	Match match = r1.Match(input);
	if (match.Success)
	{
	    string v = match.Groups[1].Value;
	    Console.WriteLine("Between One and Three: {0}",
		v);
	}
    }
}

//Output

//Between One and Three: Two