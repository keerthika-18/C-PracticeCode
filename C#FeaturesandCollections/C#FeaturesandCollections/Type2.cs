using System;
using System.Collections.Generic;
using System.Text;

namespace C_FeaturesandCollections
{
     class Type2
    {
        public void Type1()
        {
            Console.WriteLine("Type Conversion in C#:");
            int a = 10;
            long b = a;
            Console.WriteLine(b); //Implicit conversion from int to long

            int c = (int)b;//Explicit conversion from long to int
            Console.WriteLine(c);

            string str = "188";
            int d = Convert.ToInt32(str);//Converting string to int
            int e=int.Parse(str);//Converting string to int\
            Console.WriteLine(d);
            string str2 = d.ToString();//Converting int to string   
            Console.WriteLine(str2);


        }
    }
}
