using System.Collections.Generic;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var empty = Enumerable.Empty<int>();
        Console.WriteLine(empty.Count());
        int[] array = empty.ToArray();
        Console.WriteLine(array.Length);
    }
}

//Output

//0
//0