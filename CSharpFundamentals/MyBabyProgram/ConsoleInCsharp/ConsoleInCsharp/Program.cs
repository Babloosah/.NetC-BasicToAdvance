using System;

namespace ConsoleInCsharp
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your name");

            string UserName = Console.ReadLine();

            // display using concantening

            Console.WriteLine("Hello " + UserName);

            /*
                we can use place holder syntax to display the value
                instead of concatening
             */

            Console.WriteLine("Hello {0}", UserName);

            /*
                Below line of code will throw error as C# is case sensitive
                userName is not equalt o UserNameuncomment below code to see
                the error
             */
            //Console.WriteLine("Hello {0}", userName);

            /*multiple palce holder example code*/

            Console.WriteLine("Enter your age");
            string Age = Console.ReadLine();
            Console.WriteLine("Helow {0}. Your Age is {1}", UserName, Age); 
        }
    }
}