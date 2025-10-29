using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesInCSharp
{
    public class Program
    {
        static void Main()
        {
            //Calculator.Add(10, 20);

            Calculator.Add(new List<int>() { 1, 2, 3, });



            /*
                Here the number of aruments keep changing, so we cannot 
                overload fucntion with increasing number of parameters
                for every instance.

                Since we have to think about backward compatibilities of
                exisitng mwthod calls with two arguments, we can remove
                that method. 

                We can use obsolete attributes to show warning that we
                are using older method during compile time.

                Attributes can be applied to method, types, assembly level.
                
                We can also customise the attributes. Showing customised error
                message as shown in line 44 or throw an error on using
                obsolete method as shown in line 45. uncomment line 13 to 
                see the effect.
                
                
             */

        }
    }

    public class Calculator
    {
        //[Obsolete("Use Add(List<int> numbers) method")]
        [Obsolete("Use Add(List<int> numbers) method", true)]
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Add(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum = sum + number;
            }
            return sum;
        }


    }
}