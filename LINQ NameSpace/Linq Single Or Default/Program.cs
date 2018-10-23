using System;
using System.Linq;

class Program
{
    static void Main()
    {
	int[] array = { 1, 2, 3 };

	// Default is returned if no element found.
	int a = array.SingleOrDefault(element => element == 5);
	Console.WriteLine(a);

	// Value is returned if one is found.
	int b = array.SingleOrDefault(element => element == 1);
	Console.WriteLine(b);

	try
	{
	    // Exception is thrown if more than one is found.
	    int c = array.SingleOrDefault(element => element >= 1);
	}
	catch (Exception ex)
	{
	    Console.WriteLine(ex.GetType());
	}
    }
}

//Output

//0
//1
//System.InvalidOperationException