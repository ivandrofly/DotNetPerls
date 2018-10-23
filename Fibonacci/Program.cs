using System;

class Program
{
    public static int Fibonacci(int n)
    {
        // return if n is enferior equals to 0
        if (n <= 0)
            return n;

        int a = 0;
        int b = 1;
        // In N steps compute Fibonacci sequence iteratively.
        for (int i = 0; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }

    static void Main()
    {
        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }
    }
}

/*
Output

0
1
1
2
3
5
8
13
21
34
55
89
144
233
377*/