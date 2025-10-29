using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumInCsharp
{
    internal class Program
    {
        static void Main()
        {
            /*
                Strongly typed constants
             
             */

            Customer[] customers = new Customer[3];

            customers[0] = new Customer
            {
                Name = "Mark",
                Gender = 1
            };

            customers[2] = new Customer
            {
                Name = "Marry",
                Gender = 2
            };

            customers[0] = new Customer
            {
                Name = "Sam",
                Gender = 0
            };

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name = {0} and Gender = {1}", customer.Name, GetGender(customer.Gender));
            }
        }

        public static string GetGender(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "Unkown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid data detected";
            }
        }
    }

    // Gender 0 - Unknow
    // gender 1 - Male
    // gender 2 - Female
    public class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }
    }
}
