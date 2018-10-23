
using System;

class Program
{
    static void Main()
    {
	// ... Create 2D array of strings.
	string[,] array = new string[,]
	{
	    {"cat", "dog"},
	    {"bird", "fish"},
	};
	// ... Print out values.
	Console.WriteLine(array[0, 0]);
	Console.WriteLine(array[0, 1]);
	Console.WriteLine(array[1, 0]);
	Console.WriteLine(array[1, 1]);
    }
}

/*Output

cat
dog
bird
fish*/