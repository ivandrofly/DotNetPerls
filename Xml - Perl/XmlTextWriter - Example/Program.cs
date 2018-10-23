
using System;
using System.IO;
using System.Xml;

class Program
{
    static void Main()
    {
        // Create an array of four Tuple instances containing employee data.
        var array = new Tuple<int, string, string, int>[4];
        array[0] = new Tuple<int, string, string, int>(1, "David", "Smith", 10000);
        array[1] = new Tuple<int, string, string, int>(3, "Mark", "Drinkwater", 30000);
        array[2] = new Tuple<int, string, string, int>(4, "Norah", "Miller", 20000);
        array[3] = new Tuple<int, string, string, int>(12, "Cecil", "Walker", 120000);

        // Use StringWriter as backing for XmlTextWriter.
        using (StringWriter str = new StringWriter())
        using (XmlTextWriter xml = new XmlTextWriter(str))
        {
            // Root.
            xml.WriteStartDocument();
            xml.WriteStartElement("List");
            xml.WriteWhitespace("\n");

            // Loop over Tuples.
            foreach (var element in array)
            {
                // Write Employee data.
                xml.WriteStartElement("Employee");
                {
                    xml.WriteElementString("ID", element.Item1.ToString());
                    xml.WriteElementString("First", element.Item2);
                    xml.WriteWhitespace("\n  ");
                    xml.WriteElementString("Last", element.Item3);
                    xml.WriteElementString("Salary", element.Item4.ToString());
                }
                xml.WriteEndElement();
                xml.WriteWhitespace("\n");
            }

            // End.
            xml.WriteEndElement();
            xml.WriteEndDocument();

            // Result is a string.
            string result = str.ToString();
            Console.WriteLine("Length: {0}", result.Length);
            Console.WriteLine("Result: {0}", result);
        }
    }
}


//Output

//Length: 441
//Result: <?xml version="1.0" encoding="utf-16"?><List>
//<Employee><ID>1</ID><First>David</First>
//  <Last>Smith</Last><Salary>10000</Salary></Employee>
//<Employee><ID>3</ID><First>Mark</First>
//  <Last>Drinkwater</Last><Salary>30000</Salary></Employee>
//<Employee><ID>4</ID><First>Norah</First>
//  <Last>Miller</Last><Salary>20000</Salary></Employee>
//<Employee><ID>12</ID><First>Cecil</First>
//  <Last>Walker</Last><Salary>120000</Salary></Employee>
//</List>