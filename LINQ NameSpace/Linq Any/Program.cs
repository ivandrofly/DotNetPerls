using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3 };
        // See if any elements are divisible by two.
        bool b1 = array.Any(item => item % 2 == 0);
        // See if any elements are greater than three.
        bool b2 = array.Any(item => item > 3);
        // See if any elements are 2.
        bool b3 = array.Any(item => item == 2);

        // Write results.
        Console.WriteLine(b1);
        Console.WriteLine(b2);
        Console.WriteLine(b3);
    }
}

//Output

//True
//False
//True