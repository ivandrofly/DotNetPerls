using System;

namespace Basic_Generic_Usage
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<string> obj = new MyClass<string>("Ivandro");
            obj.WriteResult();

            double a = 202.3;
            double b = 323.32;

            bool c = AreEquals<double>(a, b);
            Console.WriteLine("Is {0} equals to {1} Result: {2}", a, b, c);
        }

        static bool AreEquals<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }

    class MyClass<T>
    {
        T value;

        public MyClass(T p)
        {
            // TODO: Complete member initialization
            this.value = p;
        }

        public void WriteResult()
        { Console.WriteLine(this.value); }

    }
}
