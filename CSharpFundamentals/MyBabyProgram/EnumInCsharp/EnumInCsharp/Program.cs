using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumInCsharp
{

    /*
        Enums are Enumerations.

        They are strongly typed constants.

        An explict type casting is required when we want to convert from
        integer to Enum and vice-versa.

        On .Net framwrok library, we have enum class which has getname and getvaule
        properties.

        Enum defalut datatype is integer. and it satrt with zero.

        Default data type of Enum can be changed using :

        We can also assign value to enum by using "=". Here line 32 
        is an example and on running you will see value as 1,3,3,9,10

        Enum of one type cannot be implicitly assigned to enum of 
        other type
        
     */
    //   public enum Gender : short
    public enum Gender
    {
        Male = 1,
        Female = 2,
        Unknown = 3,
        NotSpecified = 9,
        xyz = 6
    }
    internal class Program
    {
        static void Main()
        {

            Gender gender = (Gender)4;

            Console.WriteLine(gender);

            int Num = (int)Gender.Unknown;

            Console.WriteLine(Num);

            int[] values = (int[])Enum.GetValues(typeof(Gender));

            foreach (int value in values)
            {
                Console.WriteLine(value);
            }

            //short[] values = (short[])Enum.GetValues(typeof(Gender));

            //foreach (short value in values)
            //{
            //    Console.WriteLine(value);
            //    Console.WriteLine(Enum.GetValues(typeof(Gender.Male));

            //}

            string[] names = (string[])Enum.GetNames(typeof(Gender));
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
