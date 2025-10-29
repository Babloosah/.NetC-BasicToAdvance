using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVsInterfacInCsharp
{

    /*
     
    An abstarct class can have implementation for some of its
    members while interface cannot have implementation for
    any of its memebers

    interaces cannot contain field whereas abstract class can
    have fields.

    abstract class can inherit from another interfaces or other 
    abstract class where as an interface can only inherit from
    another interface and connot inherit from bastract class.

    A class can inherit from mulitple interfaces at same time 
    whereas a class connot inherit from mutiple classses at same
    time

    Abstract class members can have access modifiers whereas
    interfaces cannot have access modifiers


     */


    public abstract class Customer
    {
        int i;
        public void Print()
        {
            Console.WriteLine("Abstract calss implementation");
        }
    }

    interface ICustomer
    {
        //int i;
        void Print();
        //public void Print();
       // void Print()
       // {
       //    Console.Writeline("Print method");
       // }

    }
    internal class Program

    {
        static void Main(string[] args)
        {
        }
    }
}
