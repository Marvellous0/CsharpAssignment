using System;

namespace Question18
{
    public class Question18
    {
        public static void CheckFirstAndLastElement()
        {
            int[] nums = { 3, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 3};
            Console.WriteLine((nums.Length >= 1) && (nums[0].Equals(nums[nums.Length - 1])));
        }
    }
}
