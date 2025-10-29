using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfEnumsInCsharp
{

    public enum Gender
    {
        Unkown,
        Male,
        Female
    }

    public class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }

    public class Program
    {
        static void Main()
        {

            Customer[] customers = new Customer[3];

            customers[0] = new Customer
            {
                Name = "Mark",
                Gender = Gender.Male
            };

            customers[1] = new Customer
            {
                Name = "Marry",
                Gender = Gender.Female
            };

            customers[2] = new Customer
            {
                Name = "Sam",
                Gender = Gender.Unkown
            };

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name = {0} and Gender = {1}", customer.Name, GetGender(customer.Gender));
            }
        }

        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unkown:
                    return "Unkown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid data detected";
            }
        }
    }
}
