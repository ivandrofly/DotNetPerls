using System;
using System.Linq;

class Program
{
    static void Main()
    {
	//
	// An example array.
	//
	int[] array1 = { 5, 4, 1, 2, 3 };
	//
	// Use query expression on array.
	//
	var query = from element in array1
		    orderby element
		    select element;
	//
	// Convert expression to array variable.
	//
	int[] array2 = query.ToArray();
	//
	// Display array.
	//
	foreach (int value in array2)
	{
	    Console.WriteLine(value);
	}
    }
}

//Output

//1
//2
//3
//4
//5