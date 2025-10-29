using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsInCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UserChoice = string.Empty;

            do
            {
                Console.WriteLine("Please enter your targer");

                int UserTarget = int.Parse(Console.ReadLine());

                int start = 0;

                while (start <= UserTarget)
                {
                    //Console.WriteLine(start);
                    Console.Write(start + " ");
                    start = start + 2;
                }

                do
                {
                    Console.WriteLine("Do you want to continue - Yes or No?");

                    UserChoice = Console.ReadLine().ToUpper();
                    if (UserChoice != "YES" && UserChoice != "NO")
                    {
                        Console.WriteLine("Invalid Choice, Please say Yes or No");
                    }
                } while (UserChoice != "YES" && UserChoice != "NO");
            } while (UserChoice == "YES" );
        }
    }
}
