
using System;
using System.Linq;

class Program
{
    static void Main()
    {
	// Create an array of strings.
	string[] array = { "cat", "dog", "horse" };

	// Generate a lookup structure where the lookup is based on the key length.
	var lookup = array.ToLookup(item => item.Length);

	// Enumerate strings of length 3.
	foreach (string item in lookup[3])
	{
	    Console.WriteLine("3 = " + item);
	}

	// Enumerate strings of length 5.
	foreach (string item in lookup[5])
	{
	    Console.WriteLine("5 = " + item);
	}

	// Enumerate groupings.
	foreach (var grouping in lookup)
	{
	    Console.WriteLine("Grouping:");
	    foreach (string item in grouping)
	    {
		Console.WriteLine(item);
	    }
	}
    }
}

//Output

//3 = cat
//3 = dog
//5 = horse
//Grouping:
//cat
//dog
//Grouping:
//horse