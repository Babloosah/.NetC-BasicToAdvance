using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypes
{
    internal class Program
    {
        static void Main()
        {
            string Name = null;

            /*
                Below examples shows that we can store null values in integer data types I. 
                it throws compile time error as highlighted in yellow. Uncomment to see error.
            */
            //int i = null;

            /*
                There is a way to set value type variable to null. 
                if user dosenot select any option, we must set it to null.
                Since bool is value type variable, we use urinary operator.
            */
            bool? AreYouMajor = null;

            if (AreYouMajor == true)
            {
                Console.WriteLine("USer is major");
            }
            else if (AreYouMajor == false)
            {
                Console.WriteLine("User is not a Major");
            }
            else
            {
                Console.WriteLine("User did not specify");
            }

        }
    }
}
