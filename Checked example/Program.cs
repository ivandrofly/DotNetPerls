using System;
//http://www.dotnetperls.com/checked
class Program
{
    static void Main()
    {
        //
        // Use checked overflow context.
        //
        //checked
        {
            // Increment up to max.
            int num = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                num++;
            }
            // Increment up to max again (error).
            for (int i = 0; i < int.MaxValue; i++)
            {
                num++;
            }
            Console.WriteLine(num);
        }
    }
}