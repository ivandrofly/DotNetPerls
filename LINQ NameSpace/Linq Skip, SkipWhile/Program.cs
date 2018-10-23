
using System;
using System.Linq;

class Program
{
    static void Main()
    {
	//
	// Array that is IEnumerable for demonstration.
	//
	int[] array = { 1, 3, 5, 7, 9, 11 };
	//
	// Get collection of all elements except first two.
	//
	var items1 = array.Skip(2);
	foreach (var value in items1)
	{
	    Console.WriteLine(value);
	}
	//
	// Call Skip again but skip the first four elements this time.
	//
	var items2 = array.Skip(4);
	foreach (var value in items2)
	{
	    Console.WriteLine(value);
	}
    }
}

//Output

//5      The first two numbers in the array are missing.
//7
//9
//11

//9      The first four numbers are skipped.
//11