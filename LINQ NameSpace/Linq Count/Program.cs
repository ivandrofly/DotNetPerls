using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
	int[] array = { 1, 2, 3 };

	// Don't use Count() like this! Use Length.
	Console.WriteLine(array.Count());

	List<int> list = new List<int>() { 1, 2, 3 };

	// Don't use Count() like this! Use Count property.
	Console.WriteLine(list.Count());

	var result = from element in array
		     orderby element descending
		     select element;

	// Good.
	Console.WriteLine(result.Count());
    }
}

//Output

//3
//3
//3