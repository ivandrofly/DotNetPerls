// statements_fixed.cs
// compile with: /unsafe
using System;

class Point
{
    public int x, y;
}

class FixedTest
{
    // Unsafe method: takes a pointer to an int.
    unsafe static void SquarePtrParam(int* p)
    {
        *p *= *p;
    }

    unsafe static void Main()
    {

        UnsafeCodeApplication.TestPointer.IntPointerTest();

        Point pt = new Point();
        pt.x = 5;
        pt.y = 6;
        // Pin pt in place:
        fixed (int* p = &pt.x)
        {
            SquarePtrParam(p);
        }
        // pt now unpinned
        Console.WriteLine("{0} {1}", pt.x, pt.y);
        Console.ReadLine();
    }
}

namespace UnsafeCodeApplication
{
    class TestPointer
    {
        public unsafe static void ArrayPointer()
        {
            int[] list = { 10, 100, 200 };
            int*[] pointerArray = new int*[4];
            var x = 10;
            pointerArray[0] = &x;
            Console.WriteLine(*pointerArray[0]);
            Console.ReadLine();

            fixed (int* ptr = list) // note can't assing the ptr likst: pt
            {
                /* let us have array address in pointer */
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Address of list[{0}]={1}", i, (int)(ptr + i));
                    Console.WriteLine("Value of list[{0}]={1}", i, *(ptr + i));
                    //*(ptr + i) = 0; works
                }
            }
            Console.ReadKey();
        }

        public unsafe void swap(int* p, int* q)
        {
            int temp = *p;
            //Console.WriteLine(temp);
            *p = *q;
            *q = temp;
        }

        public unsafe static void IntPointerTest()
        {
            TestPointer p = new TestPointer();
            int var1 = 10;
            int var2 = 20;
            int* x = &var1;
            int* y = &var2;

            Console.WriteLine("Before Swap: var1:{0}, var2: {1}", var1, var2);
            p.swap(x, y);

            Console.WriteLine("After Swap: var1:{0}, var2: {1}", var1, var2);
            Console.ReadKey();
        }
    }
    // Found: http://www.tutorialspoint.com/csharp/csharp_unsafe_codes.htm
}