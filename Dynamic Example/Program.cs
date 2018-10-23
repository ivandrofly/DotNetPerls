
using System;

class Program
{
    static dynamic _y;

    static void Main()
    {
        // Use dynamic local.
        dynamic a = 1;
        Console.WriteLine(a);

        // Dynamic now has a different type.
        a = new string[0];
        Console.WriteLine(a);

        // Assign to dynamic method result.
        a = Test();
        Console.WriteLine(a);

        // Use dynamic field.
        _y = "carrot";

        // You can call anything on a dynamic variable,
        // ... but it may result in a runtime error.
        Console.WriteLine(_y.Error);
    }

    static dynamic Test()
    {
        return 1;
    }
}

/*
Output

1
System.String[]
1

Unhandled Exception: Microsoft.CSharp.RuntimeBinder.RuntimeBinderException:
    'string' does not contain a definition for 'Error'...*/