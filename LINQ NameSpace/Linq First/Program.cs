using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return string.Format("Name={0},Age={1}",
            Name,
            Age);
        }
    };

    static List<Animal> _animals = new List<Animal>()
    {
	new Animal()
	{
	    Name = "Camel",
	    Age = 5
	},
	new Animal()
	{
	    Name = "Ape",
	    Age = 3
	},
	new Animal()
	{
	    Name = "Dog",
	    Age = 6
	}
    };

    static void Main()
    {
        // A
        // Get Ape from collection
        Animal a1 = GetAnimal1("Ape");
        Console.WriteLine(a1);

        // B
        // Get Camel from collection
        Animal a2 = GetAnimal2("Camel");
        Console.WriteLine(a2);
    }

    static Animal GetAnimal1(string n)
    {
        foreach (Animal a in _animals)
        {
            if (a.Name == n)
            {
                return a;
            }
        }
        throw new Exception(n);
    }

    static Animal GetAnimal2(string n)
    {
        return _animals.First(a => a.Name == n);
    }
}

//Output

//Name=Ape,Age=3
//Name=Camel,Age=5