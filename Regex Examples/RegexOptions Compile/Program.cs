
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

class Program
{
    const int _max = 1000000;
    static void Main()
    {
        string value = "dot net 777 perls";
        var s1 = Stopwatch.StartNew();
        for (int i = 0; i < _max; i++)
        {
            Match match = Regex.Match(value, @"\d+");
        }
        s1.Stop();
        var s2 = Stopwatch.StartNew();
        for (int i = 0; i < _max; i++)
        {
            Match match = Regex.Match(value, @"\d+", RegexOptions.Compiled);
        }
        s2.Stop();
        Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
        Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
        Console.Read();
    }
}

//OutPut
//1289.84 ns
//1024.42 ns