
using System;
using System.IO;
using System.Xml;

class Program
{
    static void Main()
    {
	string input = @"<?xml version=""1.0"" encoding=""utf-16""?><List>
<Employee><ID>1</ID><First>David</First>
  <Last>Smith</Last><Salary>10000</Salary></Employee>
<Employee><ID>3</ID><First>Mark</First>
  <Last>Drinkwater</Last><Salary>30000</Salary></Employee>
<Employee><ID>4</ID><First>Norah</First>
  <Last>Miller</Last><Salary>20000</Salary></Employee>
<Employee><ID>12</ID><First>Cecil</First>
  <Last>Walker</Last><Salary>120000</Salary></Employee>
</List>";

	using (StringReader stringReader = new StringReader(input))
	using (XmlTextReader reader = new XmlTextReader(stringReader))
	{
	    while (reader.Read())
	    {
		if (reader.IsStartElement())
		{
		    switch (reader.Name)
		    {
			case "Employee":
			    Console.WriteLine();
			    break;
			case "ID":
			    Console.WriteLine("ID: " + reader.ReadString());
			    break;
			case "First":
			    Console.WriteLine("First: " + reader.ReadString());
			    break;
			case "Last":
			    Console.WriteLine("Last: " + reader.ReadString());
			    break;
			case "Salary":
			    Console.WriteLine("Salary: " + reader.ReadString());
			    break;
		    }
		}
	    }
	}
    }
}

//Output

//ID: 1
//First: David
//Last: Smith
//Salary: 10000

//ID: 3
//First: Mark
//Last: Drinkwater
//Salary: 30000

//ID: 4
//First: Norah
//Last: Miller
//Salary: 20000

//ID: 12
//First: Cecil
//Last: Walker
//Salary: 120000