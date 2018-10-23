
using System;
using System.Linq;

class Program
{
    static void Main()
    {
	int[] values = { 1, 2, 3, 4, 5, 6 };
	int last = values.Last();
	int lastOdd = values.Last(element => element % 2 != 0);

	Console.WriteLine(last);
	Console.WriteLine(lastOdd);
    }
}

//Output

//6
//5