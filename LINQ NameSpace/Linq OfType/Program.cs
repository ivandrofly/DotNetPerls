using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
	// Create an object array for the demonstration.
	object[] array = new object[4];
	array[0] = new StringBuilder();
	array[1] = "example";
	array[2] = new int[1];
	array[3] = "another";

	// Filter the objects by their type.
	// ... Only match strings.
	// ... Print those strings to the screen.
	var result = array.OfType<string>();
	foreach (var element in result)
	{
	    Console.WriteLine(element);
	}
    }
}

/*Output

example
another*/