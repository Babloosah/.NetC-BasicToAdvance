using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class Program
    {
        static void Main()
        {
            int i = 100;
            float f = i;
            Console.WriteLine(f);
            /*
             * Here an implict conversion happens since float can store much higher vaue than integer.
             * No loss of information occurs here.
            */

            float j = 123.45f;
            //int k = j;
            /*
             * since we have loss of information, we can store float to and int
             * Uncomment line number 22 to see the error.
             * It throws an compile timer error "Cannot implicitly convert type 'float' to 'int'. "
             * We can fix this in multiple ways using explict conversion
            */

            int k = (int)j;
            Console.WriteLine("with explict type cast opertor {0} ",k);
            k = Convert.ToInt32(j);
            Console.WriteLine("with convert class type casting {0} ",k);

            /*
               We dont see any difference but it will be vsisble when doing a explict
               type casting using type cast operator for a value that is much higher 
               beyond storgae cpacity of int 32. It will just assign the lowest vaue that
               int32 can store with no error or exception at run time or compile time
               wherease convert class throws an overflow excpetion at run time. 
               uncomment line number 46 & 47 to see the result.
             */

            float BigF = 6576576865678578.87768f;
            int BigI = (int)BigF;
            Console.WriteLine("Casting float {0} value to int using type cast operator gives {1}",BigF,BigI);
            //BigI = Convert.ToInt32(BigF);
            //Console.WriteLine("Casting float {0} value to int using convert class gives {1}", BigF, BigI);



            /*
                There are couple of more ways to do explict convresion.
                Parse() and TryPArse() method are used primarly when we need 
                to convert a string to integer. Let us understand how to do this.
            */

            string StrNum = "100";

           //int NumFromStr = (int)StrNum  //-- in doing this it will throw error
           int NumFromStr = Convert.ToInt32(StrNum);
           Console.WriteLine("Using convert class to convert string {0} into integer gives {1}", StrNum, NumFromStr);

            // this can alse be achieved using Parse method()
             NumFromStr = int.Parse(StrNum);
            Console.WriteLine("Using Parse method to convert string {0} into integer gives {1}", StrNum, NumFromStr);

            //Let us check how it behaves when we have non integral string value
            string NonItgrlStr = "100ft";

            //Console.WriteLine("Using convert class to convert string {0} into integer ", NonItgrlStr);
            //NumFromStr = Convert.ToInt32(NonItgrlStr);
            //Covert class will throw a FormatException: Input string was not in a correct format.

            //Console.WriteLine("Using Parse method to convert string {0} into integer ", NonItgrlStr);
            //NumFromStr = Convert.ToInt32(NonItgrlStr);
            //Parse Method will throw a FormatException: Input string was not in a correct format.

            /*
                It is wise to use these type casting techinques when we are
                sure that stirng will ahve integral values. Else we will have
                Format exceptions.
                
                To handle such scenarios we have another method called as TryParse().
                Let us understand that throughly.
            */

            int result = 0;
            int.TryParse(NonItgrlStr, out result);
            Console.WriteLine("conversion of alphanmeric string {0} into integer is : {1}", NonItgrlStr, result);
             
            /* as a result of thi, we get result as 0 since the converison has failed.
                we didin't had any excpetion.
                TryPArse method alsoe retunr a boolen data types taht says wether 
                the parse ws cucessfull or not.
            */

            bool ParseState = int.TryParse(NonItgrlStr,out result);
            if (ParseState)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }

        }
    }
}
