using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // An input data array.
        string[] array = { "cat", "dog", "mouse" };

        // Apply a transformation lambda expression to each element.
        // ... The Select method changes each element in the result.
        var result = array.Select(element => element.ToUpper());

        // Display the result.
        foreach (string value in result)
        {
            Console.WriteLine(value);
        }
    }
}

//Output

//CAT
//DOG
//MOUSE