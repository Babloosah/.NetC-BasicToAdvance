using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeBuyProgramUsingDoWhile
{
    internal class Program
    {
        static void Main()
        {
            int TotalCost = 0;
            string UserChoice = null;
            do
            {
                bool InvalidChoice = false;

                do
                {
                    InvalidChoice = false;
                    Console.WriteLine("Select youe coffee.\n 1 - Small \n 2 - Medium \n 3 - large");
                    int SelectedCoffee = int.Parse(Console.ReadLine());
                    switch (SelectedCoffee)
                    {
                        case 1:
                            TotalCost = TotalCost + 1;
                            break;
                        case 2:
                            TotalCost = TotalCost + 2;
                            break;
                        case 3:
                            TotalCost = TotalCost + 3;
                            break;
                        default:
                            Console.WriteLine("Invalid selection. Your input was {0}", SelectedCoffee);
                            InvalidChoice = true;
                            break;
                    }
                } while (InvalidChoice == true);

                do
                {
                    Console.WriteLine("Do you wish to buy more");
                    UserChoice = Console.ReadLine().ToUpper();
                    switch (UserChoice)
                    {
                        case "YES":
                        case "NO":
                            break;
                        default:
                            Console.WriteLine("Your choice {0} is invalid. Valid choices are 'yes' or 'no' ", UserChoice);
                            break;
                    } 
                } while (UserChoice != "YES" && UserChoice != "NO");
            } while (UserChoice == "YES");

            Console.WriteLine("Thank you for shopping. Your billed amount is {0}", TotalCost);
        }
    }
}
