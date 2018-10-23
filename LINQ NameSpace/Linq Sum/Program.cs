using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
	//
	// Declare two collections of int elements.
	//
	int[] array1 = { 1, 3, 5, 7 };
	List<int> list1 = new List<int>() { 1, 3, 5, 7 };

	//
	// Use Sum extension on their elements.
	//
	int sum1 = array1.Sum();
	int sum2 = list1.Sum();

	//
	// Write results to screen.
	//
	Console.WriteLine(sum1);
	Console.WriteLine(sum2);
    }
}

//Output
//    (All element values were added together to get the result.)

//16
//16