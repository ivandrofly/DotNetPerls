using System;
using System.Linq;

class Program
{
    static void Main()
    {
	// Create sequence of ten ones.
	var integers = Enumerable.Repeat(1, 10);
	// Display.
	foreach (int value in integers)
	    Console.WriteLine(value);
    }
}

//Output

//1
//1
//1
//1
//1
//1
//1
//1
//1
//1