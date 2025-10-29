namespace TwoPointersProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int []nums = { 1,1,1};
            int target = 2;

            int[] code = SumTwopairTarget(nums, target);

            Console.WriteLine("[{0},{1}]", code[0].ToString(), code[1].ToString());
            Console.WriteLine("wait");
        }

        public static int[] SumTwopairTarget (int [] numarray, int target)
        {
            int leftPointer = 0; int rightPointer = numarray.Length - 1;

            while (leftPointer < rightPointer)
            {
                if ((numarray[leftPointer] + numarray[rightPointer]) < target)
                {
                    leftPointer++;
                }
                else if ((numarray[leftPointer] + numarray[rightPointer]) > target)
                {
                    rightPointer--;
                }
                else
                {
                    return new int[] { leftPointer, rightPointer };
                }
            }
            return new int[0];
        }
    }
}
