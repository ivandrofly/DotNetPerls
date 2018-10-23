using System;
using System.Text.RegularExpressions;

class Program
{
    /// <summary>
    /// Test string using Regex.IsMatch static method.
    /// </summary>
    static bool IsValid(string value)
    {
	return Regex.IsMatch(value, @"^[a-zA-Z0-9]*$");
    }

    static void Main()
    {
	//
	// Test the strings with the IsValid method, which uses Regex.IsMatch.
	//
	Console.WriteLine(IsValid("dotnetperls0123"));
	Console.WriteLine(IsValid("DotNetPerls"));
	Console.WriteLine(IsValid(":-)"));
	// Console.WriteLine(IsValid(null)); // Throws an exception
    }
}

//Output

//True
//True
//False