using System.Collections.Generic;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
	int[] array = { 4, 5, 6 };
	int a = array.ElementAtOrDefault(0);
	int b = array.ElementAtOrDefault(1);
	int c = array.ElementAtOrDefault(-1);
	int d = array.ElementAtOrDefault(1000);

	Console.WriteLine(a);
	Console.WriteLine(b);
	Console.WriteLine(c);
	Console.WriteLine(d);
    }
}

//Output

//4
//5
//0
//0