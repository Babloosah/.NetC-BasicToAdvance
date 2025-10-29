using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionInCsharp
{

    /*
        The Program class and Customer class are compiled into package
        called as assembly.

        The assembly consist of two parts, One is intermediate lanaguage
        and other one is Metadata. 
       
        Metadata consisit of informaton about types with in assembly. For
        example it has two class program and customer. and customer class 
        has memebers like two properties, two constructor and two methods.

        So Reflection is a way to inspect assembly to find out its types
        and types memebers.

        We are creating instance of a type at compile time. This is called
        as early binding. line no 31.

        If we have to create instance of a type at run time, it is called
        as late binding.

        Reflection enables you to use code that is not available at compile 
        time

        we have serveral ways to get type of the class.

        Use typeof(class) keywoard to find teh type of class. See line 49.S
     
        we can use GetType() method on insatcne of class to fetc it types.
        see line 51 & 52.

        
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //Type T = Type.GetType("ReflectionInCsharp.Customer");

            //Type T = typeof(Customer);

            Customer c1 = new Customer();
            Type T = c1.GetType();

            Console.WriteLine(T.FullName);
            Console.WriteLine(T.Name);
            Console.WriteLine(T.Namespace);

            Console.WriteLine();

            Console.WriteLine("Properties in Customer");
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name );
            }

            Console.WriteLine();
            Console.WriteLine("Method in Customer class");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name + " " + method.ReturnType);
            }

            Console.WriteLine();
            Console.WriteLine("Constructor in Customer class");
            ConstructorInfo[] cons  = T.GetConstructors();
            foreach(ConstructorInfo con in cons)
            {
                Console.WriteLine(con.ToString());
            }
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public Customer()
        {
            this.Id = 1;
            this.Name = string.Empty;
        }

        public void PrintId()
        {
            Console.WriteLine("Id = {0}", this.Id);
        }

        public void PrintName()
        { 
            Console.WriteLine("Name = {0}", this.Name); 
        }
    }
}
