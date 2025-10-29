using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInCsharp
{
    internal class Program
    {
        static void Main()
        {
            /*
                1.  To store more than one value of similar data type in 
                    a varaiable we use array.
                
                2. Array are index based processing and starts at 0
             */

            int[] EvenNumbers = new int[3];
            EvenNumbers[0] = 0;
            EvenNumbers[1] = 2;
            EvenNumbers[2] = 4;

            Console.WriteLine(EvenNumbers[0]);

            /*
                1.  A collection of similar data types staoring group of vaules.
                
                2.  They are strongly typed meaning, If an array is of type ineteger 
                    it only stores integer values. It throws an error
                
                3.  When we access an array beyond it's size, it throw a run time
                    exception as .IndexOutOfRangeException: Index was outside the bounds of the array.
                    No error is pointed at compile time. Uncomment below code to see the result.

                4. Array cannot grow in size once initliazed.

                5. Have to rely on indices to store or retrieve items from the array.
             */

            //EvenNumbers[3] = 7;
            //Console.WriteLine(EvenNumbers[3]);

        }
    }
}


