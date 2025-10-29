using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoffeBuyProgramUSing_SwitchGotoBreak
{
    internal class Program
    {
        static void Main()
        {
            int TotalCoffeCost  = 0;

            Start:
            
            Console.WriteLine("Please select your coffee size: 1 - Small 2 - Medium, 3 - Large");
            int UserChoise  = int.Parse(Console.ReadLine());

            switch (UserChoise)
            {
                case 1:
                    TotalCoffeCost += 1;
                    break;
                case 2:
                    TotalCoffeCost += 2;
                    break;
                case 3:
                    TotalCoffeCost += 3;
                    break;
                default:
                    Console.WriteLine("Your Choice is invalid", UserChoise);
                    goto Start;
            }

            Decide:
            Console.WriteLine("Do youwant to buy another coffe -  Yes or No?");
            String UserDecision =  Console.ReadLine();

            switch (UserDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default :
                    Console.WriteLine("Your choice {0} is invalid. Please try again ..", UserDecision);
                    goto Decide;
            }
            
            Console.WriteLine("Thank you for hsopping with us");
            Console.WriteLine("Bill Amount = {0}",TotalCoffeCost);
        }
    }
}
