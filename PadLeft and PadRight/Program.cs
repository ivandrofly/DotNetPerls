using System;

// note: there is another example in: csmath project
class Program
{

    public static void PadLeftExample()
    {
        int[] a = new int[]{
	    1,
	    40,
	    6,
	    700	};

        // Output the header.
        Console.Write("Letter".PadRight(10)); // write everything after 10---------|______height spaces left then write
        Console.WriteLine("Number".PadLeft(8));

        // Output array.
        foreach (int i in a)
        {
            Console.Write("A".PadRight(10));
            Console.WriteLine(i.ToString().PadLeft(8));
        }

        /*
        Output

Letter      Number
A                1
A               40
A                6
A              700*/
    }


    static void Main()
    {
        string s = "cat".PadRight(10);
        string s2 = "poodle".PadRight(10); // Everything will be written after 10 char :)

        Console.Write(s);
        Console.WriteLine("feline");
        Console.Write(s2);
        Console.WriteLine("canine");
    }

    public void ExampleFromCSharp_Examples()
    {
        //http://www.csharp-examples.net/align-string-with-spaces/
        Console.WriteLine("-------------------------------");
        Console.WriteLine("First Name | Last Name  |   Age");
        Console.WriteLine("-------------------------------");
        Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", "Bill", "Gates", 51));
        Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", "Edna", "Parker", 114));
        Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", "Johnny", "Depp", 44));
        Console.WriteLine("-------------------------------");

        /*Output string:

         -------------------------------
         First Name | Last Name  |   Age
         -------------------------------
         Bill       | Gates      |    51
         Edna       | Parker     |   114
         Johnny     | Depp       |    44
         -------------------------------*/

    }
}

/*Output
    The left column is padded to 10 characters wide.

cat       feline
poodle    canine*/