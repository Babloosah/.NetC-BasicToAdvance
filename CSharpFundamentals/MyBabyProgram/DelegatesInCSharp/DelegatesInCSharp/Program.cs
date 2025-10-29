using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesInCSharp
{

    public delegate void HelloFunctionDelegate(string message);

    // this delegate point to any fucntion that has void return type
    // and string messagea parameter.

    internal class Program
    {
        /*
            
        Delegates are reference types.    

        A delegate is a type safe fucntion pointer. A delegates point
        to function and when we invoke a delegates, funtion will be invoked.

        Now replace return type of hello method with string. It Will throw
        an error with different return types. uncomment line 35 to see the error
         */
        static void Main(string[] args)
        {

            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello from delegate");


            List <Employee> emplist = new List<Employee>();
            emplist.Add(new Employee() { id = 101, name = "Marry", salary = 5000, Experience = 5 });
            emplist.Add(new Employee() { id = 102, name = "Mike", salary = 4000, Experience = 4 });
            emplist.Add(new Employee() { id = 102, name = "John", salary = 6000, Experience = 6 });
            emplist.Add(new Employee() { id = 102, name = "Tod", salary = 3000, Experience = 3 });

            Employee.promoteEmployee(emplist);

        }

        public static void Hello(string message)
        //public static string Hello(string message)
        {
            Console.WriteLine(message);
        }

        public class Employee
        {
            public int id { get; set; }
            public string name { get; set; }
            public int salary { get; set; }

            public int Experience { get; set; }


            /*
             The below class has hard coded logic to promote employee
             based on experience. What if i need to promote based on 
             salary. I cannot use the same method. 

            This can be obtained using delegates. it makes your fucntion 
            reusable.

            delegates are extensively used by framework developers.

             */
            public static void promoteEmployee(List<Employee> employeeList)
            {
                foreach (Employee emp in employeeList)
                {
                    if (emp.Experience >= 5)
                    {
                        Console.WriteLine(emp.name + "Promoted");
                    }
                }
            }


        }


         
    }
}
