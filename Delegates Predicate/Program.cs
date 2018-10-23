using System;

internal class Program
{
    private static void Main()
    {
        Predicate<int> predicate = value => value == 5;
        Console.WriteLine(predicate.Invoke(4));
        Console.WriteLine(predicate.Invoke(5));
    }
}

internal class ProgramClass2
{
    // ...
    // ... (Paste other methods here)
    // ...

    //static void Main()
    //{
    //    //WriteOutput("perls", new UppercaseDelegate(x => x.ToUpper()));
    //}
}