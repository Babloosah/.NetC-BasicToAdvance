using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Print();
            customer.Bussiness();

            Student student = new Student();
            student.Print1();
            student.Print2();

           // ICustomer customer2 = new ICustomer();
            ICustomer cust = new Customer();
            cust.Print();
        }
    }

    /*
        Interface keywoard is used to create interface.

        Interface in gneerale are prefixed by capital 'I'.
        This is standar practise to identify the interface.

        Interface can only contain declaration. Definition
        is not allowed. uncomment line 44 to see error

        Interface member are public by default. We cannot have
        explicit access modifier. Uncomment lin 43 to see error

        Interface can not have field. uncomment line 45 to see error

        A class can inherit interface. Any class inheriting
        interface must implement interface memebrs. Signature
        of implementation must be same as interface memebers.

        When we inherit a interface which has already inherited
        from another interface, we must provide implemenation for
        both the interface. Comment 74 to 78 to see error.

        We cannot create insatnce of an interface. Since interface
        does not have implenetation, we cannot create instace. But,
        we can create interface refrecne varaible pointing to an
        object of derived class.


     */

    interface ICustomer
    {
        void Print();

        //public void print();
       // void print() { Console.WriteLine("Test")};
       //int i;
    }

    interface IBussines
    {
        void Bussiness();
    }

    interface IStudent1
    {
        void Print1();
    }

    interface IStudent2 : IStudent1
    {
        void Print2();
    }

    class Student : IStudent2
    {
        public void Print1()
        {
            Console.WriteLine("Istudent 1 method");
        }

        public void Print2()
        {
            Console.WriteLine("Istudent 2 method");
        }
    }

    class Customer : ICustomer, IBussines
    {
        public void Bussiness()
        {
            Console.WriteLine("IBussines interfaec method");
        }

        public void Print()
        {
            Console.WriteLine("Interface method");
        }
    }

}
