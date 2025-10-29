using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MethodInCsharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
                Method are also called as functions. These terms ar used 
                interchangeably.

                Mian methid has static keyword. so it as static method.

                Whereas if  static keywoard is not presnt then it is called as
                instance method.

                To invoke instance method, we need to create a instance of the class.
                Instance method can only be invoked from instance of an class.

             */

            Program p = new Program();

            Console.WriteLine("Calling via a instance");
            p.InstanceMethodEvenNumbers();

            /*
                To invoke static method we call it direclty using class name.
                If you try to invoke it with instance it will throw an error.

                Uncomment line 37 to see the error when invoking from instance.
            */

            // p.StaticMethodEvenNumbers();
            Console.WriteLine("Calling via a class name");
            Program.StaticMethodEvenNumbers();

            /*
                Parameterised method with single input
             */
            Console.WriteLine("Calling parameterized method");
            p.InstanceMethodEvenNumbers(10);

            Console.WriteLine("Calling parameterized method which returns value");
            int sum = p.SumofTwoNumber(10, 12);

            Console.WriteLine("sum of 10 and 12 is {0}.", sum);



            /*
                Let us understand pass by value and pass by reference
             */

            int j = 10;
            Console.WriteLine("The value of j before calling value method is {0}", j);
            p.DemoByValue(j);
            Console.WriteLine("The value of j after calling value method is {0}", j);

            Console.WriteLine("The value of j before calling reference method is {0}", j);
            p.DemoByReference(ref j);
            Console.WriteLine("The value of j after calling reference method is {0}", j);

            int total = 0;
            int product = 0;
            p.DemoOfOutParm(10,20,out total,out product);
            Console.WriteLine("sum is {0} and product is {1}", total, product);  
        
            p.DemoOfParamsArray(1,2,3);
            p.DemoOfParamsArray();
            p.DemoOfParamsArray(1,2,3,4,5,6);

            // params keyword must be the last parameter of any given method
            // else it will throw an error.

            //Value that we pass during calling , it is called as arguments
            // Declaration has parameters.
        }

        /// <summary>
        /// Print all the even numbers till 20
        /// </summary>

        /*
            This is an example of instance method
         */
        public void InstanceMethodEvenNumbers()
        {
            int start = 0;
            while (start <= 20)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }

        /*
            This is an example of instance method
         */
        public static void StaticMethodEvenNumbers()
        {
            int start = 0;
            while (start <= 20)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }

        /// <summary>
        /// Print all the even numbers till given target
        /// </summary>

        /*
            This is an example of instance method with inpur parameter.
         */
        public void InstanceMethodEvenNumbers( int target)
        {
            int start = 0;
            while (start <= target)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }

        /// <summary>
        /// retrun sum of two given number
        ///</summary>
        
        public int SumofTwoNumber(int a, int b)
        {
            return a + b;
        }


        /// <summary>
        /// Demo of passing by value
        ///</summary>

        public void DemoByValue(int a)
        {
            a=20;
        }

        /// <summary>
        /// Demo of passing by reference
        ///</summary>

        public void DemoByReference(ref int a)
        {
            a = 20;
        }


        /// <summary>
        /// Demo of output parameter
        ///</summary>

        public void DemoOfOutParm( int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
        }


        /// <summary>
        /// Demo of parameter array.
        ///</summary>

        public void DemoOfParamsArray(params int[] numbers)
        {
            Console.WriteLine("There are {0} elements.", numbers.Length);

            foreach (int i in numbers)
            { 
                Console.WriteLine(i);
            }
        }

    }
}
