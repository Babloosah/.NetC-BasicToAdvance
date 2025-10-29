using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripletProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int> { 0, -1, 2, -3, -1 };
            var triplets = TripletSumOptimized(nums);

            Console.WriteLine("Unique triplets that sum to 0:");
            foreach (var triplet in triplets)
            {
                Console.WriteLine($"[{string.Join(", ", triplet)}]");
            }

        }

        public static List<List<int>> TripletSumOptimized(List<int> nums)
        {
            nums.Sort();
            List<List<int>> triplets = new List<List<int>>();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > 0)
                    break;

                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                var pairs = FindTwoSumPairs(nums, i + 1, -nums[i]);
                foreach (var pair in pairs)
                {
                    triplets.Add(new List<int> { nums[i], pair[0], pair[1] });
                }
            }

            return triplets;
        }


        public static List<List<int>> FindTwoSumPairs(List<int> nums, int start, int target)
        {
            List<List<int>> pairs = new List<List<int>>();
            int left = start, right = nums.Count - 1;

            while (left < right)
            {
                int sum = nums[left] + nums[right];

                if (sum == target)
                {
                    pairs.Add(new List<int> { nums[left], nums[right] });
                    left++;
                    right--;

                    while (left < right && nums[left] == nums[left - 1]) left++;
                    while (left < right && nums[right] == nums[right + 1]) right--;
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return pairs;
        }

    }
}
