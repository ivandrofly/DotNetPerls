using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Single
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
using System;
using System.Linq;

class Program
{
    static void Main()
    {
	// Find only element > 999.
	int[] array1 = { 1, 3, 1000, 4, 5 };
	int value1 = array1.Single(element => element > 999);

	// Ensure only one element.
	int[] array2 = { 4 };
	int value2 = array2.Single();

	Console.WriteLine(value1);
	Console.WriteLine(value2);

	// See exception when more than one element found.
	try
	{
	    int value3 = array1.Single(element => element > 0);
	}
	catch (Exception ex)
	{
	    Console.WriteLine(ex.GetType());
	}
    }
}

//Output

//1000
//4
//System.InvalidOperationException