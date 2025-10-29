using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePartialClass
{
    public partial class SamplePartialClass
    {
        /*
            Since there is no definition or implemenetation of Sample
            PartailMEthod(), the compiler ignore the calls and definition
            of partial method.

            Now on adding, implemnetation of partail method on other file, it calls 
            the partial method and print partial metehod invoked.

            Partial method are private by defualt. And its compile time error to include
            any access modifiers, including private.

            its compile time error if we have implemention and delaration at same time

            Only Void return type is accepted. Any other retunr type will throw
            compile time error

            Signature of partial declaration and implementation must be same. Else
            compile time error

            Only partial class can implement partial method. else compiler error.

            Partial class can be implemented only once.
         */

        partial void SamplePartialethod();

        public void PublicMehtod()
        {
            Console.WriteLine("Public method invoked");
            SamplePartialethod();
        }
    }
}
