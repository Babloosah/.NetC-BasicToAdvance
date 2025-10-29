using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LateBindingInCsharp
{

    /*
        Missspell at compile time can be deteted at compile time. 
        We use early bidning when we have information about all the class
        involved in program.
        Lets comment the customer class and its instance.

        Late binding is done, when we dont have information about class at
        compile time. If we need to compile that we will use alte binding.


     */
    public class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type customertype = assembly.GetType("LateBindingInCsharp.Customer");
            object customerInstance  = Activator.CreateInstance(customertype);

            MethodInfo getFullNameMethod = customertype.GetMethod("GetFullName");

            string[] parameters = new string[2];
            parameters[0] = "Tew";
            parameters[1] = "Tech";

            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);
            Console.WriteLine("Full Name = {0}", fullName);


            //Customer c1 = new Customer();
            //string fullname = c1.GetFullName("TEW", "Tech");
            //Console.WriteLine("Full Name = {0}", fullname);
        }
    }

    public class Customer
    {
        public string GetFullName(string firstname, string lastname)
        {
            return (firstname + " " + lastname);
        }
    }
}
