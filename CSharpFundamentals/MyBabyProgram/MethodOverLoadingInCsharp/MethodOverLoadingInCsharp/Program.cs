using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoadingInCsharp
{
    internal class Program
    {

        /*
            Method overloading allow you to use same mehtod name with different
            parameters.

            Based on kind of parameter

            Overloading can be done based on number, type(int, float, etc) and
            kind(value or reference or out) of parameters.

            Singanture of method consist of the name, type of the parameter, 
            number of parameter and the kind of parameters. However, the return
            type is not the part of signature. 

            we can not overload method based on return type of method

            We cant overload method using params keywoard parmaeter
         */
        public static void Main()
        {
            Add(3, 4);
        }

        public static void Add(int FN, int SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }

        public static void Add(float FN, float SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }

        public static void Add(float FN, int SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }

        public static void Add(int FN, int SN, int TN)
        {
            Console.WriteLine("Sum = {0}", FN + SN + TN);
        }

        public static void Add(int FN, int SN, out int TN)
        {
            TN = FN + SN;
        }

        public static void Add(int FN, float SN, int TN, int gn)
        {
            Console.WriteLine("Sum = {0}", FN + SN + TN + gn);
        }
    }
}
