using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    class Employee
    {
        public string Name { get; set; }
        public int EmpID { get; set; }
        public string DeptName { get; set; }
    }

    class Dept
    {
        public string DeptName { get; set; }
        public string Manager { get; set; }
    }

    List<Employee> employee = new List<Employee>();
    List<Dept> dept = new List<Dept>();

    static void Main()
    {
        /*var intance = new Program();
        var NaturalJoin =
            from emp in intance.employee
            join dep in intance.dept on emp.Name equals dep.Manager into Employee_Dept
            select new { Name = emp.Name, EmpId = emp.EmpID, DeptName = emp.DeptName, Manager = emp.Name };

        foreach (var n in NaturalJoin)
        {
            Console.WriteLine(n.Name + " " + n.EmpId + " " + n.Name + " " + n.Manager + " ");
        }*/
        Join1();
    }

    public static void Join1()
    {
        // Array 1.
        var ints1 = new int[3];
        ints1[0] = 4;
        ints1[1] = 3;
        ints1[2] = 0;

        // Array 2.
        var ints2 = new int[3];
        ints2[0] = 5;
        ints2[1] = 4;
        ints2[2] = 2;

        {
            // Join with method call.
            var result = ints1.Join<int, int, int, int>(ints2, x => x + 1, y => y, (x, y) => x);
            var result2 = ints1.Join(ints2, x => x + 1, y => y, (x, y) => x);

            // Display results.
            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        }

        {
            // Join with query expression.
            var result = from t in ints1
                         join x in ints2 on (t + 1) equals x
                         select t;

            Console.WriteLine("test");
            // Display results.
            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        }
    }
}

//Output

//4  (First loop)
//3
//4  (Second loop)
//3