using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProblemInMultiClassInheritance
{
    internal class Program
    {

        class A
        {
            public virtual void Print()
            {
                Console.WriteLine("A Implementation");
            }
        }

        class B : A
        {
            public override void Print()
            {
                Console.WriteLine("B implementation");
            }
        }

        class C : A
        {
            public override void Print()
            {
                Console.WriteLine("C implementation");
            }
        }

        //class D:B,C
        //{
        //
        //}

        interface IA
        {
            void AMethod();
        }

        class E : IA
        {
            public void AMethod()
            {
                Console.WriteLine("A");
            }
        }

        interface IB
        {
            void BMethod();
        }

        class F : IB
        {
            public void BMethod()
            {
                Console.WriteLine("B");
            }
        }

        class EF : IA, IB
        {
            F f = new F();
            E e = new E();
            public void AMethod()
            {
                e.AMethod();
            }

            public void BMethod()
            { 
                f.BMethod();
            }
        }






        static void Main(string[] args)
        {
            /*
             
            C# dosenot support multi class inheritance.

            instead we can obtain some using interface.

            class a and class b will inherit from interface IA and IB
            with the implemntation of interface ia and ib

            class AB will inherit from class interface ia and ib.
            but we will not implement the interface as these were 
            implemented in class A and clas B. 

            So, by crating object of calss a and B, we will be able
            to inherit the function of both class methods.             
            
             */

            //D d  = new D();
            //d.Print();

            EF ef = new EF();
            ef.AMethod();
            ef.BMethod();
        }
    }
}
