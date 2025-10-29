using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInCsharp
{

    public class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);  

        }

    }


    /*
        1. Child class is specialization of base class
        2. Below are two derived class 
        3. C# only support single class inheritance i.e. a class can have
           only 1 base class.
        4. Multi level inheritance is possible. 
        5. Multiple interface interference.
        6. Base class is automatically instantiated before parent class.
        7. Parent class constructor executes before child class constructor
     */

    public class FUllTimeEmployee : Employee
    {
        
        public float yearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public float HourlSalary;
    }


    //Example of multi level class
    public class MultiLevelClass : PartTimeEmployee
    {

    }

    internal class Program
    {
        static void Main()
        {
            FUllTimeEmployee FTE = new FUllTimeEmployee();
            FTE.firstName = "TEW";
            FTE.lastName = "Technologies";
            FTE.email = "theengineersWay@TEW.com";
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.firstName = "Part";
            PTE.lastName = "Time";
            PTE.PrintFullName();

            MultiLevelClass multiLevelClass = new MultiLevelClass();
            multiLevelClass.firstName = "Multi";
            multiLevelClass.lastName = "Level";
            multiLevelClass.PrintFullName();

           /*
            * PArent calss constructor will be called while calling child class
            * by default parameter less constructor will be called.
            * Derived class constructor can control parent class constructor using base keywoard
            */
           
            ChildClass childClass = new ChildClass();
           

            


        }
    }



    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent class constructor is called");
        }

        public ParentClass(string message)
        { 
            Console.WriteLine(message); 
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass() : base("Message from derived class contrloing parent class") 
        {
            Console.WriteLine("Child class constructor is called");

        }
    }

}
