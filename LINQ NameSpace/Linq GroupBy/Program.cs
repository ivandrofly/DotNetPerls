using System.Collections.Generic;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Input array.
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


#if false
        int[] array_2 = { 2, 2, 4, 4, 1, 2, 34, 3, 43, 2 };
        var grouped = array_2.GroupBy(x => x).Select(x => x.First());

        foreach (var item in grouped)
        {
            Console.WriteLine("value: {0}", item);
        }
        System.Diagnostics.Debugger.Break(); 
#endif

        // Group elements by IsEven.
        var result = array.GroupBy(a => IsEven(a));

        // Loop over groups.
        foreach (var group in result)
        {
            // Display key for group.
            Console.WriteLine("IsEven = {0}:", group.Key);

            // Display values in group.
            foreach (var value in group)
            {
                Console.Write("{0} ", value);
            }

            // End line.
            Console.WriteLine();
        }
    }

    static bool IsEven(int value)
    {
        return value % 2 == 0;
    }
}

//Output

//IsEven = False:
//1 3 5 7 9
//IsEven = True:
//2 4 6 8