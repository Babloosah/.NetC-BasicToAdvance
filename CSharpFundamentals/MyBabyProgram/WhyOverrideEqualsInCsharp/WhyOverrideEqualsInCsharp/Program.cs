using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyToOverrideToStringInCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                
                == is reference equality check where as equal() method gives value
                equality. So customer.equals(customer3) should be true which give
                false. Hence we need to override equals methods
                
                
                
             */
            int i = 10;
            int j = 10;
            Console.WriteLine(i == j);
            Console.WriteLine(i.Equals(j));

            Direction direction1 = Direction.East;
            Direction direction2 = Direction.West;

            Console.WriteLine(direction1 == direction2);    
            Console.WriteLine(direction2.Equals( direction1));

            Customer customer = new Customer();
            customer.firstName = "Simon";
            customer.lastName = "Tan";

            Customer customer2 = customer;

            Console.WriteLine(customer == customer2);
            Console.WriteLine(customer.Equals(customer2));

            Customer customer3 = new Customer();
            customer3.firstName = "Simon";
            customer3.lastName = "Tan";

            Console.WriteLine(customer == customer3);
            Console.WriteLine(customer.Equals(customer3));


        }
    }

    public enum Direction
    {
        East = 1,
        West = 2,
        North = 3,
        South = 4
    }

    public class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {  
                return false; 
            }

            if (!(obj is Customer))
            {
                return false;
            }

            return this.firstName == ((Customer)obj).firstName
                && this.lastName == ((Customer)obj).lastName;    

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
