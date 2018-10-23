using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int[] array = { 10, 20, 30 };

        // Are all elements >= 10? YES
        bool a = array.All(element => element >= 10);

        // Are all elements >= 20? NO
        bool b = array.All(element => element >= 20);

        // Are all elements < 40? YES
        bool c = array.All(element => element < 40);

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}

//Output

//True
//False
//True