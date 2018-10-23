using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Declare an array with some duplicated elements in it.
        int[] array1 = { 1, 2, 2, 3, 4, 4 };
        // Invoke Distinct extension method.
        var result = array1.Distinct();
        // Display results.
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