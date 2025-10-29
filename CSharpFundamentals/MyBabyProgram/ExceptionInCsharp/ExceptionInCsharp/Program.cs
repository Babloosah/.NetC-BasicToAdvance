using System;
using System.IO;

namespace ExceptionInCsharp
{
    internal class Program
    {
        static void Main()
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"D:\CSharpFundamentals\Learning\1Data.txt");
                Console.WriteLine(streamReader.ReadToEnd());
            }

            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Check if the file {0} exists", ex.FileName);
                //Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            finally
            {
                if (streamReader != null)
                    streamReader.Close();

                Console.WriteLine("Finally block executed");
            }
        }
    }
}
