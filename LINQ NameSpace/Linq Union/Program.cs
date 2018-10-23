using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create two example arrays.
        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 2, 3, 4 };
        // Union the two arrays.
        var result = array1.Union(array2);
        // Enumerate the union.
        foreach (int value in result)
        {
            Console.WriteLine(value);
        }
    }
}

//Output

//1
//2
//3
//4