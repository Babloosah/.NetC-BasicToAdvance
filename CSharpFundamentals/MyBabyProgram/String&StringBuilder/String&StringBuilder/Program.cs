using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_StringBuilder
{

    /*
        System.String is immutable. You cannot change the object in heap memory.
        So when we concatenate a new string in any existing string it will create 
        a reference to new object pointing to newly concatenated string. Untill
        the garbage colleciton run, the memory will be allocated to these 
        unrefered objects. 

        String of type stringBuilder will be muttable. MEaning, we will only have
        one object created fro any number of concatenation operation resulting 
        in better performance for heavy string operation.
        
        String is present in system.Strin namespaces where as Stringbuilde
        is present in system.Text namespace
     
        

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string userString = "C#";
            userString += " Video";
            userString += " Tutorial";
            userString += " for";
            userString += " Beginners";
            Console.WriteLine(userString);

            StringBuilder userString2 = new StringBuilder("C#");
            userString2.Append(" Video");
            userString2.Append(" Tutorial");
            userString2.Append(" for");
            userString2.Append(" Beginners");
            Console.WriteLine(userString2.ToString());

            /*
                Below code will cause severe memory problem as using string 
                to concatenate from 1 to 10000 will create 9999 unused object.

                Instead the wise decison will be to use Stringbuilder type
                
            */

            String conc = string.Empty;
            for (int i = 0; i < 10000; i++)
            {
                conc += i.ToString() + " ";
            }
            Console.WriteLine(conc);

            StringBuilder conc2 = new StringBuilder();
            for (int i = 0;i <10000;i++)
            {
                conc2.Append(i.ToString() + " ");
            }
            Console.WriteLine(conc2);

        }
    }
}
