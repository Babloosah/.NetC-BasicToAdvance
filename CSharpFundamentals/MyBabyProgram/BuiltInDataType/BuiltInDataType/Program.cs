using System;
using System.Xml;

namespace BuiltInDataType
{
    internal class Program
    {
        static void Main()
        {
            /* 
                Store boolean data into bool data type which can only
                store True or false
            */
            bool LearningStatus = true;

            Console.WriteLine("Bool variable 'LearningStatus' has value of {0}", LearningStatus);

            /* 
                Bool variable can only have true or false as valid value.
                If we try to store any other values it will throw error
                at compile time.
            */

            //LearningStatus = 12;


            /*
                integer, floating or decimal value can be stored in four
                defferent data types like byte, short, int, long,etc.
            */

            Console.WriteLine("Minimum value that int data types can store is: {0} ", int.MinValue);
            Console.WriteLine("Maximum value that int data types can store is: {0} ", int.MaxValue);



            Console.WriteLine("Minimum value that float data types can store is: {0} ", float.MinValue);
            Console.WriteLine("Maximum value that float data types can store is: {0} ", float.MaxValue);

            double d = 1.23456779879787979879d;
            Console.WriteLine("The vaue of double d is: {0}",d);

            float f = 1.23456779879787979879f;
            Console.WriteLine("The vaue of float d is: {0}", f);

            decimal di = 1.23456779879787979879m;
            Console.WriteLine("The vaue of decimal d is: {0}", di);

            /*
                To understand the difference between float, double and decimal
                use below methods
            */


             f = 1f/3;
            Console.WriteLine("The vaue of float d is: {0}", f);

            d = 1d / 3;
            Console.WriteLine("The vaue of double d is: {0}", d);

             di = 1m/3;
            Console.WriteLine("The vaue of decimal d is: {0}", di);

            /*
                Undertanding string in very important as we have very
                high use on this built in type.

                String is alway written within ". Double quotes. 

                Escape sequence character helps us to handle special
                character in C#.
            */

            string name = "Tew";
            Console.WriteLine(name);

            // if i need to rpint '"' along with the name, escape sequnce 
            // can be used.
            string name1 = "\"Tew";
            Console.WriteLine(name1);

            // "\" backslash is called as escape sequnce character in C#.

            /*
                Sometimes we need a string that has backslash '\' like 
                file path etc. We can use verbatim literal that makes
                this as normal character. 
            */

            string filepath = "c:\\learn\\csharp.txt";
            Console.WriteLine("String without verbatim literal looks like: {0}", filepath);

            string vbfilepath = @"c:\learn\csharp.txt";
            Console.WriteLine("String with verbatim literal looks like: {0}", vbfilepath);

            //USe of verbatim make code more readable

        }
    }
}
