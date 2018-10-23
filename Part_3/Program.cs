//C# program that uses ToString methods

using System;

class Program
{
    static void Part3()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine(now.ToLongDateString());  // Equivalent to D.
        Console.WriteLine(now.ToLongTimeString());  // Equivalent to T.
        Console.WriteLine(now.ToShortDateString()); // Equivalent to d.
        Console.WriteLine(now.ToShortTimeString()); // Equivalent to t.
        Console.WriteLine(now.ToString());
    }
}

/*Output

ToLongDateString     Friday, February 27, 2009
ToLongTimeString     12:16:59 PM
ToShortDateString    2/27/2009
ToShortTimeString    12:16 PM
ToString             2/27/2009 12:16:59 PM*/