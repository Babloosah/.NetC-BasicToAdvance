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
            int number = 10;
            Console.WriteLine(number.ToString());

            Customer c1 = new Customer();
            c1.firstName = "Simon";
            c1.lastName = "Tan";
            Console.WriteLine(c1.ToString());


            int i = 10;
            int j = 10;
            Console.WriteLine(i == j);
            Console.WriteLine(i.Equals(j));

        }
    }

    public class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public override string ToString()
        {
            return this.lastName + " " + this.firstName;
        }
    }
}
