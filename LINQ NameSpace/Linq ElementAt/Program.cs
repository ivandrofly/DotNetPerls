using System.Collections.Generic;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
	// Input array.
	string[] array = { "Dot", "Net", "Perls" };

	// Test ElementAt for 0, 1, 2.
	string a = array.ElementAt(0);
	Console.WriteLine(a);
	string b = array.ElementAt(1);
	Console.WriteLine(b);
	string c = array.ElementAt(2);
	Console.WriteLine(c);

	// This is out of range.
	string d = array.ElementAt(3);
    }
}

//Output

//Dot
//Net
//Perls

//Unhandled Exception: System.ArgumentOutOfRangeException: Index was out of range.