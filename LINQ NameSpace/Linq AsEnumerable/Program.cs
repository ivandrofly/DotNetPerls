using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create an array type.
        int[] array = new int[2];
        array[0] = 5;
        array[1] = 6;
        // Call AsEnumerable method.
        IEnumerable<int> query = array.AsEnumerable();
        IEnumerable<int> ints = (IEnumerable<int>)array;
        foreach (var element in query)
        {
            Console.WriteLine(element);
        }
    }
}

//Output

//5
//6

//Implementation of AsEnumerable: .NET

//public static IEnumerable<TSource> AsEnumerable<TSource>(this IEnumerable<TSource> source)
//{
//    return source;
//}