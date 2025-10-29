using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInitialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];
            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3;
            nums[3] = 4;

            int[] nums2 = new int[5] {1,2,3,4,5};

            int[] nums3 = { 1, 2, 3, 4, 5 };

            foreach(int i in nums) {Console.WriteLine(i); }
            foreach(int i in nums2) {Console.WriteLine(i); }
            foreach( int i in nums3) {Console.WriteLine(i);}
        }
    }
}
