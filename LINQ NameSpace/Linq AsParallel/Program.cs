using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static int SumDefault(int[] array)
    {
        /*
         *
         * Sum all numbers in the array.
         *
         * */
        return array.Sum();
    }

    static int SumAsParallel(int[] array)
    {
        /*
         *
         * Enable parallelization and then sum.
         *
         * */
        return array.AsParallel().Sum();
    }

    static void Main()
    {
        // Generate array.
        int[] array = Enumerable.Range(0, short.MaxValue).ToArray();

        // Test methods.
        Console.WriteLine(SumAsParallel(array));
        Console.WriteLine(SumDefault(array));

        const int m = 10000;
        var s1 = Stopwatch.StartNew();
        for (int i = 0; i < m; i++)
        {
            SumDefault(array);
        }
        s1.Stop();
        var s2 = Stopwatch.StartNew();
        for (int i = 0; i < m; i++)
        {
            SumAsParallel(array);
        }
        s2.Stop();
        Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) /
            m).ToString("0.00 ns"));
        Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) /
            m).ToString("0.00 ns"));
        Console.Read();
    }
}

//Result for 32767 elements

//536821761
//536821761
//232450.53 ns
//118515.85 ns