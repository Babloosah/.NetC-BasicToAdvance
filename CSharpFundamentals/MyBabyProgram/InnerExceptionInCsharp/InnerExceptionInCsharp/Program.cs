using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerExceptionInCsharp
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter the first number");
                    int fn = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the second number");
                    int sn = Convert.ToInt32(Console.ReadLine());

                    int result = fn / sn;

                    Console.WriteLine("Result = {0}", result);
                }

                catch (Exception ex)
                {
                    string filePath = @"D:\CSharpFundamentals\Learning\ExceptionLog1.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.WriteLine(ex.GetType().Name);
                        sw.WriteLine(ex.Message);
                        sw.Close();
                        Console.WriteLine("There is a problem, Please try later");
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + "is not present", ex);
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Current exception = {0}", e.GetType().Name);
                Console.WriteLine("Inner exception = {0}", e.InnerException.GetType().Name); 
            }

        }
    }
}
