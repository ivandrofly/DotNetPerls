
using System;
using System.Linq;

class Program
{
    static void Main()
    {
	string[] array1 = { "dot", "net", "perls" };
	string[] array2 = { "a", "different", "array" };
	string[] array3 = { "dot", "net", "perls" };
	string[] array4 = { "DOT", "NET", "PERLS" };

	bool a = array1.SequenceEqual(array2);
	bool b = array1.SequenceEqual(array3);
	bool c = array1.SequenceEqual(array4, StringComparer.OrdinalIgnoreCase);

	Console.WriteLine(a);
	Console.WriteLine(b);
	Console.WriteLine(c);
    }
}

//Output

//False
//True
//True