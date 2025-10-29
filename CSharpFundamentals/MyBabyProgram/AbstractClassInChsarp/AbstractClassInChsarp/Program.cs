using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassInChsarp
{

    /*
        To create a abstract class we create abstarct. 
    
        Abstract class are incomlete. they have anstract members.
        Any member can be abstarct like properties, method, events, and indexers, etc.

        Any abstarct memeber cannot have its implementataions.
        An abstract class mya contain abstract meber but not
        mandatory. I can have no abstarct members.

        Since abstract class are incomplete, we cannot create 
        an instacne of abstract class.

        Abstract class are created to make it a base class that can 
        be inherited by other child class.

        Inheriting class must implement abstract members for parent
        abstract class. We can bypass implementataion, by maing child
        class as abstract too.

        Abstract class cannot be sealed. Sealed class means it can not
        be inherited or used as base class.


     */

    abstract class Customer
    {
        public abstract void print();
    }

    internal class Program : Customer
    {


        static void Main(string[] args)
        {
            Program program = new Program();
            program.print();

            Customer customer  = new Program();
            customer.print();
        }

        public override void print()
        {
            Console.WriteLine("Print Method");
        }

    }

}
