using System;

class Program
{
    delegate void D(string value);
    delegate void myDelegate(int input1, int input2);

    static void Main()
    {
        // ... Specify delegate with lambda expression.
        D d = v => Console.WriteLine(v); // this will automatically invoke the d.Inkoke("Cat")
        // ... Invoke delegate.
        d.Invoke("cat");

        // this will calculate the 2 numbers and printout the result
        myDelegate calc = (a, b) => Console.WriteLine(a + b);
        calc.Invoke(12, 2);
    }
}