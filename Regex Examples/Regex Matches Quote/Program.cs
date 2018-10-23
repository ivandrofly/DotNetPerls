using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // The input string
        string line = "INSERT INTO country VALUES ('BH','BAHRAIN','Bahrain','BHR','048');";

        // Match all quoted fields
        MatchCollection col = Regex.Matches(line, @"'(.*?)'");

        // Copy groups to a string array
        string[] fields = new string[col.Count];
        for (int i = 0; i < fields.Length; i++)
        {
            fields[i] = col[i].Groups[1].Value; // (Index 1 is the first group)
        }

        // Display the fields
        foreach (string field in fields)
        {
            Console.WriteLine(field);
        }
    }
}

//Output
//BH
//BAHRAIN
//Bahrain
//BHR
//048