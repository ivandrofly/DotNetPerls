using System;

//http://www.dotnetperls.com/prime
class Program
{
    static void Main()
    {
        //
        // Write prime numbers between 0 and 100.
        //
        goto Test2;
        Console.WriteLine("--- Primes between 0 and 100 ---");
        for (int i = 0; i < 100; i++)
        {
            bool prime = PrimeTool.IsPrime(i);
            if (prime)
            {
                Console.Write("Prime: ");
                Console.WriteLine(i);
            }
        }
    Test2:
        //
        // Write prime numbers between 10000 and 10100
        //
        Console.WriteLine("--- Primes between 10000 and 10100 ---");
        for (int i = 10000; i < 10100; i++)
        {
            if (PrimeTool.IsPrime(i))
            {
                Console.Write("Prime: ");
                Console.WriteLine(i);
            }
        }
    }
}

public static class PrimeTool
{
    public static bool IsPrime(int candidate)
    {
        // Test whether the parameter is a prime number.
        if ((candidate & 1) == 0)
        {
            if (candidate == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Console.WriteLine(Math.Sqrt(7)); // :)
        //System.Diagnostics.Debugger.Break();

        // Note:
        // ... This version was changed to test the square.
        // ... Original version tested against the square root.
        // ... Also we exclude 1 at the end.
        for (int i = 3; (i * i) <= candidate; i += 2)
        {
            if ((candidate % i) == 0)
            {
                return false;
            }
        }
        return candidate != 1;
    }
}

/*
Output

--- Primes between 0 and 100 ---
Prime: 2
Prime: 3
Prime: 5
Prime: 7
Prime: 11
Prime: 13
Prime: 17
Prime: 19
Prime: 23
Prime: 29
Prime: 31
Prime: 37
Prime: 41
Prime: 43
Prime: 47
Prime: 53
Prime: 59
Prime: 61
Prime: 67
Prime: 71
Prime: 73
Prime: 79
Prime: 83
Prime: 89
Prime: 97
--- Primes between 10000 and 10100 ---
Prime: 10007
Prime: 10009
Prime: 10037
Prime: 10039
Prime: 10061
Prime: 10067
Prime: 10069
Prime: 10079
Prime: 10091
Prime: 10093
Prime: 10099*/