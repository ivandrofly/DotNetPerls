using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
	// Contains four values.
	int[] values1 = { 1, 2, 3, 4 };

	// Contains three values (1 and 2 also found in values1).
	int[] values2 = { 1, 2, 5 };

	// Remove all values2 from values1.
	var result = values1.Except(values2);
    IEnumerable<int> results = values1.Except(values2); // using System.Collections.Generic;

	// Show.
	foreach (var element in result)
	{
	    Console.WriteLine(element);
	}
    }
}

//Output

//3
//4