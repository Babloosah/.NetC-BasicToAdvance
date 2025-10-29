using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScndLargestElementArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 6, 6, 6, 6, 6, 6 };

            int firstNum = int.MinValue;
            int secondNum = int.MinValue;

            foreach (int num in nums)
            {
                if (num > firstNum)
                {
                    secondNum = firstNum;
                    firstNum = num;
                }
                else if (num > secondNum && num != firstNum)
                {
                    secondNum = num;
                }

            }

            if (secondNum != int.MinValue)
            {
                Console.WriteLine("Second largest number is: {0}", secondNum);
            }
            else
            {
                Console.WriteLine("No Distinct second largest number found");
            }
        }
    }
}
