using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach_ForLoopInCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            /*
                A foreach loop is used to interate through items in a collection.
                For example, foreach loop can be used with arrays or collections 
                such as arraylist, HashTable and generics. This is faster than 
                other looping mechanism
             */
            Console.WriteLine("Using for each loop");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            /*
                for loop is veru similar to while loop. In while loop
                we do the initialization ate one place. condition check at
                another place and modifying the variable at third place, 
                where as in foor loop all of these happens at one place.
             */
            Console.WriteLine("Using for loop");
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine(numbers[j]);
            }

            Console.WriteLine("Using while loop");
            int i = 0;
            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i++;
            }

            /*
                We will understand the use or break and continue via simple program

                Break : it breaks out of loop. 

                Continue : it bypass all the statement after continue and move to next iteration

                We are writing below program that will loop through 20 numbers.
                COntinue will bypass each loop with odd number
                Break will break it out of code.
             */


            Console.WriteLine("Break and Continue statament");
            for (int j = 0; i <= 20; j++)
            {
                Console.WriteLine("My current loop is {0}.", j);
                if (j % 2 == 1)
                {
                    Console.WriteLine("Bypassing odd loop.");
                    continue;
                }

                if (j > 10)
                {
                    Console.WriteLine("Breaking out of loop as break statment was executed.");
                    break;
                }


                Console.WriteLine(j);


            }

        }
    }
}
