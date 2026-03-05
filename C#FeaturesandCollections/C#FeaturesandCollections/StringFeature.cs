using System;
using System.Collections.Generic;
using System.Text;

namespace C_FeaturesandCollections
{
    class StringFeature
    {
        public void StringFeatures()
        {
            Console.WriteLine("String Features in C#");
            string a = "Hello";
            Console.WriteLine(a);
            string b = "World";
            Console.WriteLine(b);
            string c = string.Concat(a, " ", b);
            Console.WriteLine(c);
            string d=c.ToUpper();
            Console.WriteLine(d);
            string e=d.Replace("WORLD","C#");
            Console.WriteLine(e);
            string f = e.Substring(0, 5);
            Console.WriteLine(f);
            string g = f.ToLower();
            Console.WriteLine(g);
            string h = g.Insert(0, "Greeting: ");
            Console.WriteLine(h);
            string i = h.Remove(0, 10);
            Console.WriteLine(i);
            Console.WriteLine(i.Count());
            string[] words = i.Split(' ');
            IEnumerable<string>wordList=words;
            Console.WriteLine("Words in the string:"+wordList);
            Console.WriteLine(wordList.Count());
            Console.WriteLine(i.Trim());


        }
    }
}
