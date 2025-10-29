using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAbuseInCsharp
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Please enter Numerator");
                int Numerator = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter Denominator");
                int Denominator = Convert.ToInt32(Console.ReadLine());

                int result = Numerator / Denominator;

                Console.WriteLine("Result = {0}", result);
            }

            catch (FormatException)
            {
                Console.WriteLine("please enter a number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Only number between {0} & {1} is allwoed", Int32.MinValue, Int32.MaxValue);
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Denominator can not be zero");
            }

            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message); 
            }
        }
    }
}
