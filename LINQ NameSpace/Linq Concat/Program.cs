using System.Collections.Generic;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array1 = { 1, 3, 5 };
        int[] array2 = { 0, 2, 4 };

        // Concat array1 and array2.
        var result1 = array1.Concat(array2);
        foreach (int value in result1)
        {
            Console.WriteLine(value);
        }
        Console.WriteLine();

        // Concat array2 and then array1.
        var result2 = array2.Concat(array1);
        foreach (int value in result2)
        {
            Console.WriteLine(value);
        }
    }
}

//Output

//1
//3
//5
//0
//2
//4

//0
//2
//4
//1
//3
//5