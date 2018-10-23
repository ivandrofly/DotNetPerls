using System;
using System.Collections;
using System.Linq;

public class ReporterWindow
{
    static void Main()
    {
        var n1 = Enumerable.Range(0, 15).ToArray();
        var n2 = Enumerable.Range(0, 15).ToArray();

        foreach (var item in n1)
        {
            Console.WriteLine(item);
        }
        Console.ReadLine();
    }
}