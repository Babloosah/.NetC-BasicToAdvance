using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsInCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number = 10;
            /*
                single qual to '=' represent assignment 
                dibule quals '==' reprsent comapriosn
                && is AND operator
                || is OR opertor
             */
            if (Number == 10) {Console.WriteLine("Number: {0}",Number);}

            /*
                Ternary operator
             */

            bool IsNumber10;
            if (Number == 10)
            {
                IsNumber10 = true;
            }
            else
            { 
                IsNumber10 = false; 
            }

            Console.WriteLine("Number ==10 is {0}", IsNumber10);

            /*
                All this multiple line of code can be written in single line using single
                line code using ternary code.
             */

            bool IsNumber11 = Number == 11 ? true : false;
            Console.WriteLine("Number ==11 is {0}", IsNumber11);
        }
    }
}
