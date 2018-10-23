using System;

// Unsafe could be added here to avoid adding in each method with uses pointer
class Program
{

    static void Main()
    {
        Console.WriteLine("Writing \\0: ");
        Console.Write('\0');
        Console.ReadLine();


        Console.WriteLine(Transform());
        //Console.WriteLine(Transform());
        //Console.WriteLine(Transform());

        ExampleFixedPointer();
    }

    unsafe static string Transform()
    {
        goto label;
        // Get random string.
        string value = "ivandro"; //System.IO.Path.GetRandomFileName();

        //fixed (char* thispointer = value)
        //{
        //    //Console.WriteLine(*(thispointer + 1));
        //    Console.WriteLine(thispointer->ToString());
        //    //Console.WriteLine(*thispointer[0]);
        //}

        double d = 10;
        // Use fixed statement on a char pointer.
        // ... The pointer now points to memory that won't be moved!
        fixed (char* pointer = value)
        {
            // Add one to each of the characters.
            for (int i = 0; pointer[i] != '\0'; ++i)
            {
                //*(pointer + 1)
                pointer[i]++;
            }

            for (int i = 0; pointer[i] != '\0'; i++)
            {
                //*(pointer + 1)
                pointer[i]++;
            }

            //Sgoto label;
            // Return the mutated string.
            return new string(pointer);
        }
    label:
        int k = 10;
        int* p = &k;
        int* ptr = (int*)k; // this is dangerous (Note 10 will be casted to memory address 10 = which may contain data from another app 0x0000000a);
        try { Console.Write(*ptr); }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Invalid memory address");
        }
        *p = 12;
        //Console.WriteLine(p->ToString());
        Console.WriteLine(*p);
        return string.Empty;
    }

    // Found at: http://www.dotnetperls.com/unsafe
    unsafe static void ExampleFixedPointer()
    {
        //string s = "sam";
        fixed (char* value = "sam")
        {
            char* ptr = value;
            // value = 'a'; canont assign to value because it's fixed variable
            // *value = *(value + 3); value will be \0

            //Console.Write(*value);
            // *value = &(s[0]); error
            while (*ptr != '\0')
            {
                Console.WriteLine(*ptr);
                ++ptr;
            }
        }
        Console.ReadLine();
    }

    public unsafe static int CountTagInText(char* ptr, char tag)
    {
        int count = 0;
        while (*ptr != '\0')
        {
            if (*ptr == '\n')
                count++;
            ptr++;
        }
        return count;
    }
}