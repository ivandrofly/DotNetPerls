using System;

// A Delegate is a type safe function pointer
public delegate void HelloFunctionDelegeate(string Message);

public delegate int Ivandro(int one, int two);

internal class Program
{
    private static void Main()
    {
        // Delegate objects
        HelloFunctionDelegeate Del1 = Hello; // |  += without ()
        var Del2 = new HelloFunctionDelegeate(_Hello);

        // Print void Methods
        Del1("I'm Hello #Del1");
        Del2("I'm _Hello #Del2");

        // Printing Fuction Method
        Ivandro i = new Ivandro(Ismael);
        Console.WriteLine(i(23, 392));
    }

    public static void Hello(string strMessage)
    {
        Console.WriteLine(strMessage);
    }

    public static void _Hello(string strMessage)
    {
        Console.WriteLine(strMessage);
    }

    public static int Ismael(int x, int y)
    {
        return x * y;
    }
}