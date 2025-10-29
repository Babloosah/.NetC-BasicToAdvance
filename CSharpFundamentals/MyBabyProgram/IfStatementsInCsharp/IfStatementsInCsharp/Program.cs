using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementsInCsharp
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number");
            int UserNumber  =   int.Parse(Console.ReadLine());

            if (UserNumber == 1)
            {
                Console.WriteLine("Your number is one");
            }

            else if (UserNumber == 2)
            {
                Console.WriteLine("Your number is two");
            }

            else if (UserNumber == 3)
            {
                Console.WriteLine("Your number is three");
            }

            else
            {
                Console.WriteLine("Your number is not between 1 and 3");
            }

            /* 
                Difference between && and & is that if any codition is false it wont
                check other condition in && where as in single & it will check all 
                the conditon , same goes for ||. 

                Dobule && and || are called as short circuit operators.
             */

            /*
                Switch , break and goto statement
                Multiple if else statement can be replaced by swich ststament.
            */

            Console.WriteLine("Using Switch statement");
            switch (UserNumber)
            {   
                case 1:
                    Console.WriteLine("Your number is One");
                    break;
                case 2:
                    Console.WriteLine("Your number is Two");
                    break;
                case 3:
                    Console.WriteLine("Your number is Three");
                    break;
                default:
                    Console.WriteLine("Your number is not between 1 and three");
                    break;
            }

            //Multiple case in with single action item.
            switch (UserNumber)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Your number is {0}",UserNumber);
                    break;
                default:
                    Console.WriteLine("Your number is not between 1 and three");
                    break;
            }


        }
    }
}
