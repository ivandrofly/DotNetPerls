using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
	//
	// This List has three elements.
	//
	var list = new List<string>() { "Cat", "Rat", "Mouse" };
	Console.WriteLine(list.FirstOrDefault());

	//
	// This query produces no results so FirstOrDefault is null.
	//
	var query1 = from element in list
		    where element.Length > 10
		    select element;
	Console.WriteLine(query1.FirstOrDefault() == null);

	//
	// This query produces one result, so FirstOrDefault is a string.
	//
	var query2 = from element in list
		     where element.Length > 3
		     select element;
	Console.WriteLine(query2.FirstOrDefault());

	//
	// This array has no elements, so FirstOrDefault is zero.
	//
	int[] array = new int[0];
	Console.WriteLine(array.FirstOrDefault());
    }
}

//Output

//Cat
//True
//Mouse
//0