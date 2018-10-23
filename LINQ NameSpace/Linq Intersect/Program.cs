using System.Collections.Generic;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Assign two arrays.
        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 2, 3, 4 };
        // Call Intersect extension method.
        var intersect = array1.Intersect(array2);
        // Write intersection to screen.
        foreach (int value in intersect)
        {
            Console.WriteLine(value);
        }
    }
}

//Output

//2
//3