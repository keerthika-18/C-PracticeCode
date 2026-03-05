using System;
using System.Collections.Generic;
using System.Text;

namespace C_FeaturesandCollections
{
    class Nullable2
    {
        public void Run()
        {   Console.WriteLine("Nullable types in C#:");
            int a = 10;
            int? b = null;
            int? c = 20;
            if (b.HasValue)
            {
                Console.WriteLine($"Value of b: {b.Value}");
            }
            else
            {
                Console.WriteLine("b is null");
                if(c.HasValue)
                {
                    Console.WriteLine($"Value of c: {c.Value}");
                }
            }
            Console.WriteLine(b.GetValueOrDefault(18)); // Output: 18
             Console.WriteLine(c.GetValueOrDefault(18)); // Output: 20))
            //Null coalescing
            int? k = null;
            int e = k ?? 6;
            Console.WriteLine(e);

        }
    }
}
