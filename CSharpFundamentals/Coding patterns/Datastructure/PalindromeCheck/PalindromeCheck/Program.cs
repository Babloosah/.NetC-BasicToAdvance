using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 0, 4, 3, 2, 1 };
            bool isPalidrome = true;

            int start = 0;
            int end = nums.Length - 1;

            while (start < end)
            {
                if (nums[start] == nums[end])
                {
                    start++;
                    end--;
                }
                else
                {
                    isPalidrome = false;
                    end--;
                }
            }
            if (isPalidrome)
            {
                Console.WriteLine("The series is palindrome");
            }
            else
            {
                Console.WriteLine("The series is non palindrome");
            }
        }
    }
}
