using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // Use extension method.
        bool a = list.Contains<int>(7);
        // Use instance method.
        bool b = list.Contains(7);

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}

//Output

//True
//True