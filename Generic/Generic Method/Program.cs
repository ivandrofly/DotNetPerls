using System;
using System.Collections.Generic;

class Program
{
    static List<T> GetInitializedList<T>(T value, int count)
    {
        // This generic method returns a List with ten elements initialized.
        // ... It uses a type parameter.
        // ... It uses the "open type" T.
        List<T> list = new List<T>();
        for (int i = 0; i < count; i++)
        {
            list.Add(value);
        }
        return list;
    }

    static bool isEquals<T>(T t1, T t2)
    {
        return t1.Equals(t2) ? true : false;
    }

    bool isNot<T>(T t1)
    {
        return true;
    }

    static void Main()
    {
        // Use the generic method.
        // ... Specifying the type parameter is optional here.
        // ... Then print the results.
        List<bool> list1 = GetInitializedList(true, 5);
        List<string> list2 = GetInitializedList<string>("Perls", 3);
        List<double> list3 = GetInitializedList<double>(20.20, 2); // Added by Ivandro Ismael

        foreach (bool value in list1)
        {
            Console.WriteLine(value);
        }

        foreach (string value in list2)
        {
            Console.WriteLine(value);
        }

        if (isEquals<string>("Ivandro", "Ivandro"))
        {
            Console.WriteLine("They are equals");
        }

        // this will not work cause object is required
        /*if(isNot<string>("ivandro ismael"))
        {

        }*/
    }
}

//Output

//True
//True
//True
//True
//True
// ----
//Perls
//Perls
//Perls