using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person() { Salary = 1000 };
            //var result = person--; // won't workd

            Console.WriteLine("Before");
            Console.WriteLine(person.Salary);
            //var rs = person++;
            person++; // since is ref type no holding variable are requred... e.g: above.
            Console.WriteLine("After");
            Console.WriteLine(person.Salary);
            //more info: http://www.dotnetperls.com/operator
            Console.ReadLine();
        }
    }

    class Person
    {
        public int Salary { get; set; }
        /*public static int operator --(Person x)
        {
            return x.Salary - 2;
        }*/
        public static Person operator ++(Person x)
        {
            x.Salary = x.Salary + 1;
            return x;
        }
    }
}
