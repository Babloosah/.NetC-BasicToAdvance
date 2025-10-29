using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTosSring_ToStringDifference
{
    internal class Program
    {
        /*
            Convert.ToString() handle null, whike ToString() doesn't
            and thriw a NULL refrence expection
            
            Depending on the type of application, architecture and what
            you aren trying to achieve, you choode one over the other

         */
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            string str= customer.ToString();
            Console.WriteLine(str);

            str=Convert.ToString(str);
            Console.WriteLine(str);

            Customer customer2 = null;
            string str2 = customer2.ToString();
            Console.WriteLine(str2);

            str2 = Convert.ToString(customer2);
            Console.WriteLine(str2);

        }
    }

    public class Customer
    {
        public string name { get; set; }
    }
}
