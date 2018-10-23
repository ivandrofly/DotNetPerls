using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

class Customer
{
    public int Code { get; set; }
    public string Name { get; set; }
}

class Order
{
    public int KeyCode { get; set; }
    public string Product { get; set; }
}

class Result
{
    public string Name { get; set; }
    public IEnumerable<Order> Collection { get; set; }
    public Result(string name, IEnumerable<Order> collection)
    {
        this.Name = name;
        this.Collection = collection;
    }
}

class Program
{
    static void Main()
    {
        // Example customers.

        var customers = new Customer[]
        {
            new Customer{Code = 5, Name = "Sam"},
            new Customer{Code = 6, Name = "Dave"},
            new Customer{Code = 7, Name = "Julia"},
            new Customer{Code = 8, Name = "Sue"}
        };

        // Example orders.
        var orders = new Order[]
	{
	    new Order{KeyCode = 5, Product = "Book"},
	    new Order{KeyCode = 6, Product = "Game"},
	    new Order{KeyCode = 7, Product = "Computer"},
	    new Order{KeyCode = 7, Product = "Mouse"},
	    new Order{KeyCode = 8, Product = "Shirt"},
	    new Order{KeyCode = 5, Product = "Underwear"}
	};

        // Correlate "customers" with "orders"
        // ... Use Code property as key for Customer.
        // ... Use KeyCode property as key for Order.
        // ... For each result, create object with Name and IEnumerable of orders.
        var query = customers.GroupJoin(orders,
            c => c.Code,
            o => o.KeyCode,
            (c, result) => new Result(c.Name, result));

        // Enumerate results.
        foreach (var result in query)
        {
            Console.WriteLine("{0} bought...", result.Name);
            foreach (var item in result.Collection)
            {
                Console.WriteLine(item.Product);
            }
        }
    }
}

//Output

//Sam bought...
//Book
//Underwear
//Dave bought...
//Game
//Julia bought...
//Computer
//Mouse
//Sue bought...
//Shirt