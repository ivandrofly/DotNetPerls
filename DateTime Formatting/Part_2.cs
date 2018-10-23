//C# program that tests formats

using System;

class Program
{
    static void FormattingPart2()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine(now.ToString("d"));
        Console.WriteLine(now.ToString("D"));
        Console.WriteLine(now.ToString("f"));
        Console.WriteLine(now.ToString("F"));
        Console.WriteLine(now.ToString("g"));
        Console.WriteLine(now.ToString("G"));
        Console.WriteLine(now.ToString("m"));
        Console.WriteLine(now.ToString("M"));
        Console.WriteLine(now.ToString("o"));
        Console.WriteLine(now.ToString("O"));
        Console.WriteLine(now.ToString("s"));
        Console.WriteLine(now.ToString("t"));
        Console.WriteLine(now.ToString("T"));
        Console.WriteLine(now.ToString("u"));
        Console.WriteLine(now.ToString("U"));
        Console.WriteLine(now.ToString("y"));
        Console.WriteLine(now.ToString("Y"));
    }
}
/*
Output

d    2/27/2009
D    Friday, February 27, 2009
f    Friday, February 27, 2009 12:11 PM
F    Friday, February 27, 2009 12:12:22 PM
g    2/27/2009 12:12 PM
G    2/27/2009 12:12:22 PM
m    February 27
M    February 27
o    2009-02-27T12:12:22.1020000-08:00
O    2009-02-27T12:12:22.1020000-08:00
s    2009-02-27T12:12:22
t    12:12 PM
T    12:12:22 PM
u    2009-02-27 12:12:22Z
U    Friday, February 27, 2009 8:12:22 PM
y    February, 2009
Y    February, 2009*/