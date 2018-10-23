using System;
using System.Linq;

class Program
{
    static void Main()
    {
	// Create an array.
	int[] array = { 1, 2, 4 };
	// Call reverse extension method on the array.
	var reverse = array.Reverse();
	// Write contents of array to screen.
	foreach (int value in reverse)
	{
	    Console.WriteLine(value);
	}
    }
}

//Output

//4
//2
//1