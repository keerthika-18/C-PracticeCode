using System;
using System.Collections.Generic;
using System.Text;

namespace C_FeaturesandCollections
{
    public class Exception_except
    {
        public void ExceptionHandling()
        {
            Console.WriteLine("Exception Handling in C#");
            int a = 0;
            try{
                int c = 1000 / a;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                               Console.WriteLine("Execution completed.");
            }

            try
            {
                int f = int.Parse("abcde");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Exception,", ex);
            }

            try
            {
                string hell= null;
            }
            catch(NullReferenceException ex)
            {
                throw new System.Exception("Null point exception", ex);   
            }
        }
    }
}
