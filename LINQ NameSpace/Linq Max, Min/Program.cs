using System;
using System.Linq;

class Program
{
    static void Main()
    {
	int[] array1 = { 1, -1, -2, 0 };

	// Find maximum number.
	Console.WriteLine(array1.Max());

	// Find maximum number when all numbers are made positive.
	Console.WriteLine(array1.Max(element => Math.Abs(element)));
    }
}

//Output

//1
//2