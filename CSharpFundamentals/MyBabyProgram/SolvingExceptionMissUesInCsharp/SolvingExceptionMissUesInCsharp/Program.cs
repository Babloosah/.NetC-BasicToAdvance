using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace SolvingExceptionMissUesInCsharp
    {
        internal class Program
        {
            static void Main()
            {
                try
                {
                    Console.WriteLine("Please enter Numerator");
                    //int Numerator = Convert.ToInt32(Console.ReadLine());

                    int numerator;
                    bool isNumeratorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out numerator);


                    if (isNumeratorConversionSuccessful)
                    {
                        Console.WriteLine("Please enter Denominator");
                        //int Denominator = Convert.ToInt32(Console.ReadLine());
                        int denominator;
                        bool isDenominatorSuccessful = Int32.TryParse(Console.ReadLine(), out denominator);

                        if (isDenominatorSuccessful && denominator > 0)
                        {
                            int result = numerator / denominator;
                            Console.WriteLine("Result = {0}", result);
                        }
                        else
                        {
                            if (isDenominatorSuccessful == false)
                            {
                                Console.WriteLine("Numerator shoud be a valid number between {0} & {1} is allwoed", Int32.MinValue, Int32.MaxValue);
                            }
                            else
                            {
                                Console.WriteLine("Denominator cannot be zero");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Numerator shoud be a valid number between {0} & {1} is allwoed", Int32.MinValue, Int32.MaxValue);
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
