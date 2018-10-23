using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
	//
	// Use Average to compute average value.
	//
	double[] array1 = { 1, 2, 3, 5, 0 };
	double average1 = array1.Average();
	Console.WriteLine(average1);
	//
	// Use Average to compute average string length.
	//
	string[] array2 = { "dog", "cat", "perls" };
	double average2 = array2.Average(x => x.Length);
	Console.WriteLine(average2);
    }
}

//Output

//2.2
//3.66666666666667