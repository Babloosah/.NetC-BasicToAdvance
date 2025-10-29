using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxValueInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -15, 18, 0, -17, -13, };

            Array.Sort(nums);
            Console.WriteLine("Max Value is: {0}",nums[nums.Length-1]);

            int maxValue = nums[0];

            foreach (int i in nums)
            {
                maxValue = maxValue < i ? i : maxValue;
            }

            Console.WriteLine("Max Value is: {0}", maxValue);
        }
    }
}
