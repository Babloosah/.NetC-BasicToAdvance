using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsInCsharp
{

    /*
        Usually the function we write are tighlty coupled with data type

        Here, calculator function is tightly coupled to integer data type,
        We cann't pass string with it

        one option is by using object type in fucntion. We know that .Net 
        framework, any type inhert from object type.

        There are 2 problem with this method. 
        1. At run time, the value type will be converted to reference type. 
            this is called as boxing. So boxing and unboxing will take time
            resulting in performance issue.
        2. The function was written to check if two smiliar type of values
            are equal or not. But since we are using object, we can pass any
            type of values in arguments. one can be 10 and other can be 'AB'.
            Comparing 10 with 'AB' doesnot make sense.
        3. These problem can be solved using Generics. Both the parameter 
            be same and the method will be stongly typed and will allow any 
            data similar data types.
        4. We can make classes,interface, delegates generics.
        

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool equal = Calculator.AreEqual(1, 2);

            //bool equal = Calculator.AreEqual("a", "a");

            bool equal = Calculator.AreEqual("a", "a");
            //equal = Calculator.AreEqual(10, 10);

            if (equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

        }
    }

    public class Calculator
    {
      //  public static bool AreEqual(int value1, int value2)
       // public static bool AreEqual(object value1, object value2)

        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
