using System;
using System.Collections.Generic;
using System.Text;

namespace C_FeaturesandCollections
{
    public class SystemObject
    {
        public string Name { get; set; }
        public void System()
        {
            Console.WriteLine("Demonstrating System.Object methods:");
            SystemObject obj1 = new SystemObject { Name = "KIKI" };
                

            SystemObject obj2 = new SystemObject {Name="KIKI"};
            Console.WriteLine("obj1.ToString(): " + obj1.ToString());
            Console.WriteLine("obj2.ToString(): " + obj2.ToString());
            Console.WriteLine("obj1.Equals(obj2): " + obj1.Equals(obj2));
            Console.WriteLine("obj1.GetHashCode(): " + obj1.GetHashCode());
            Console.WriteLine("obj2.GetHashCode(): " + obj2.GetHashCode());
            Console.WriteLine("obj1.GetType(): " + obj1.GetType());
            Console.WriteLine("obj2.GetType(): " + obj2.GetType());
            Console.WriteLine("ReferenceEquals(obj1, obj2): " + ReferenceEquals(obj1, obj2));
            Console.WriteLine("ReferenceEquals(obj1, obj1): " + ReferenceEquals(obj1, obj1));

            Console.WriteLine("");

        }
    }
}
