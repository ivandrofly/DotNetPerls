/*.NET 4.5

C# program that uses DateTime format*/
using System;

class Program
{
    static void Main()
    {
        DateTime time = DateTime.Now;             // Use current time.
        string format = "MMM ddd d HH:mm yyyy";   // Use this format.
        Console.WriteLine(time.ToString(format)); // Write to console.
    }
}

/*Output

Feb Fri 27 11:41 2009

Format string pattern

MMM     display three-letter month
ddd     display three-letter day of the WEEK
d       display day of the MONTH
HH      display two-digit hours on 24-hour scale
mm      display two-digit minutes
yyyy    display four-digit year*/


// Note: http://www.dotnetperls.com/datetime-format