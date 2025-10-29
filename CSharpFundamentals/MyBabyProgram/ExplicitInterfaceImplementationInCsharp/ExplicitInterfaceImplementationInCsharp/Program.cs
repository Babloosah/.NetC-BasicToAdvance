using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceImplementationInCsharp
{

    interface I1
    {
        void InterfaceMethod();
    }

    interface I2
    {
        void InterfaceMethod();
    }

    internal class Program : I1, I2
    {

        /*
            In case when we have same method signature im multiple
            interface, we need to explicitly implement the method.
            We will eb able to compile it successfully as the compiler
            thinks that method from both the interfaces were implemented.

            Check line 42 and 43 as an example of typecasting.
            But this doesnot make difference as we still ahve single
            implementation for btoh interface.

            We have to explictiy implment interface method too by removin
            public access modifier.

            Instead of typecasting, we can create an instance of 
            each referece pointing to an obejct of  program class.
         
            We can set one of the interface as defult method. we can
            do so by implementing one method normally and other with
            interface. perfix on method name
         */
        public void InterfaceMethod() 
        {
            Console.WriteLine("I1 Interface method");
        }

        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 Interface method");
        }
        static void Main()
        {
            Program p = new Program();
          //  p.InterfaceMethod(); // this doesnt work as we have explciitly typecasted both the implementation.
            ((I1)p).InterfaceMethod();
            ((I2)(p)).InterfaceMethod();

            I1 i1 = new Program();
            i1.InterfaceMethod();
            I2 i2 = new Program();
            i2.InterfaceMethod();

            Program pgm = new Program();
            pgm.InterfaceMethod();
            ((I2)pgm).InterfaceMethod();


        }
    }
}
