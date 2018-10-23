using System;
using System.Linq;

class Program
{
    static void Main()
    {
	// Create array of tuples.
	Tuple<int, int>[] tuples = new Tuple<int, int>[3];
	tuples[0] = new Tuple<int, int>(3, 6);
	tuples[1] = new Tuple<int, int>(6, 4);
	tuples[2] = new Tuple<int, int>(0, 60);

	// Order by descending on Item1.
	var result = tuples.OrderByDescending(a => a.Item1);
	foreach (var item in result)
	{
	    Console.WriteLine(item);
	}
    }
}

//Output

//(6, 4)
//(3, 6)
//(0, 60)