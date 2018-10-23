using System;

internal class Program
{
    // More samples in: http://www.dotnetperls.com/delegate
    private delegate string UppercaseDelegate(string input);

    private static void Main()
    {
        // Wrap the methods inside delegate instances and pass to the method.
        WriteOutput("ivandro", new UppercaseDelegate(UppercaseFirst));
        WriteOutput("ismael", new UppercaseDelegate(UppercaseLast));
        WriteOutput("ivandrofly", new UppercaseDelegate(UppercaseAll));
        WriteOutput("playstation", new UppercaseDelegate(UppercaseFirstLast));
    }

    private static string UppercaseAll(string input)
    {
        return input.ToUpper();
    }

    private static string UppercaseFirst(string input)
    {
        // return input.Substring(0, 1).ToUpper() + input.Substring(1);
        char[] buffer = input.ToCharArray();
        buffer[0] = char.ToUpper(buffer[0]);
        return new string(buffer);
    }

    private static string UppercaseFirstLast(string input)
    {
        char[] buffer = input.ToCharArray();
        buffer[buffer.Length - 1] = char.ToUpper(buffer[buffer.Length - 1]);
        buffer[0] = char.ToUpper(buffer[0]);
        return new string(buffer);
    }

    private static string UppercaseLast(string input)
    {
        char[] buffer = input.ToCharArray();
        buffer[buffer.Length - 1] = char.ToUpper(buffer[buffer.Length - 1]);
        return new string(buffer);
    }

    private static void WriteOutput(string input, UppercaseDelegate del)
    {
        Console.WriteLine("Your string before: {0}", input);
        Console.WriteLine("Your string after: {0}", del(input));
    }
}