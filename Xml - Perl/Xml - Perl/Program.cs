using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string perls = @"C:\Users\Ivandrofly-LK\Documents\Visual Studio 2012\Projects\C# - Tutorials\C# - DotNetPerls Examples\Xml - Perl\perls.xml";
        // Create an XML reader for this file.
        using (XmlReader reader = XmlReader.Create(perls))
        {
            while (reader.Read())
            {
                // Only detect start elements.
                if (reader.IsStartElement())
                {
                    Console.WriteLine(reader.Name); // returns the name of current element which is "perls"
                    // Get element name and switch on it.
                    switch (reader.Name)
                    {
                        case "perls":
                            // Detect this element.
                            Console.WriteLine("Start <perls> element.");
                            break;
                        case "article":
                            // Detect this article element.
                            Console.WriteLine("Start <article> element.");
                            // Search for the attribute name on this current node.
                            string attribute = reader["name"];
                            if (attribute != null)
                            {
                                Console.WriteLine("  Has attribute name: " + attribute);
                            }
                            // Next read will contain text.
                            if (reader.Read())
                            {
                                Console.WriteLine("  Text node: " + reader.Value.Trim());
                            }
                            break;
                    }
                }
            }
        }
    }
}

// OUTPUT:

//Start <perls> element.
//Start <article> element.
//  Has attribute name: backgroundworker
//  Text node: Example text.
//Start <article> element.
//  Has attribute name: threadpool
//  Text node: More text.
//Start <article> element.
//  Text node:
//Start <article> element.
//  Text node: Final text.