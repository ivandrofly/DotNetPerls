using System;

class Layout
{
    string[] _values = new string[100]; // Backing store

    public string this[int number]
    {
        get
        {
            // This is invoked when accessing Layout instances with the [ ].
            if (number >= 0 && number < _values.Length)
            {
                // Bounds were in range, so return the stored value.
                return _values[number];
            }
            // Return an error string.
            return "Error";
        }
        set
        {
            // This is invoked when assigning to Layout instances with the [ ].
            if (number >= 0 && number < _values.Length)
            {
                // Assign to this element slot in the internal array.
                _values[number] = value;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        // Create new instance and assign elements
        // ... in the array through the indexer.
        Layout layout = new Layout();
        layout[1] = "Frank Gehry";
        layout[3] = "I. M. Pei";
        layout[10] = "Frank Lloyd Wright";
        layout[11] = "Apollodorus";
        layout[-1] = "Error";
        layout[1000] = "Error";

        // Read elements through the indexer.
        string value1 = layout[1];
        string value2 = layout[3];
        string value3 = layout[10];
        string value4 = layout[11];
        string value5 = layout[50];
        string value6 = layout[-1];

        // Write the results.
        Console.WriteLine(value1);
        Console.WriteLine(value2);
        Console.WriteLine(value3);
        Console.WriteLine(value4);
        Console.WriteLine(value5); // Is null
        Console.WriteLine(value6);
    }
}

//Output

//Frank Gehry
//I. M. Pei
//Frank Lloyd Wright
//Apollodorus
//(null)
//Error