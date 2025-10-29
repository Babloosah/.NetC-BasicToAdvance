using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RotateArrayBy2Pos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };

            Console.WriteLine("Before rotating");
            foreach (int i in nums) {Console.Write(i);}
            Console.WriteLine();

            int rotatePos = 4;
            int length = nums.Length;

            rotatePos = rotatePos % length;

            int[] rotatedNums = new int[length];

            for(int i = 0; i < length;i++)
            {
                rotatedNums[(i+rotatePos) % length] = nums[i];
            }
            Console.WriteLine("After rotating 2 position by right");
            foreach (int i in rotatedNums) { Console.Write(i + " "); }

        }
    }
}
