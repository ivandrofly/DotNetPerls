using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Aggregate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int result = array.Aggregate((a, b) => b + a);
            // 1 + 2 = 3
            // 3 + 3 = 6
            // 6 + 4 = 10
            // 10 + 5 = 15
            Console.WriteLine(result);

            result = array.Aggregate((a, b) => b * a);
            // 1 * 2 = 2
            // 2 * 3 = 6
            // 6 * 4 = 24
            // 24 * 5 = 120
            Console.WriteLine(result);
        }
    }
}

//Output

//15
//120