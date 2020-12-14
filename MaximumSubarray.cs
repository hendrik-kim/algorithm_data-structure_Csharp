using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_DataStructure_Csharp
{
    class MaximumSubarray
    {
        //public int crossSum(int[] nums, int left, int right, int pivot)
        //{
        //    if (left == right) return nums[left];

        //    int leftSubSum = int.MinValue;
        //    int rightSubSum = int.MinValue;
        //    int currSum = 0;

        //    for (int i = pivot; i > left - 1; --i)
        //    {
        //        currSum += nums[i];
        //        leftSubSum = Math.Max(leftSubSum, currSum);
        //    }

        //    currSum = 0;

        //    for (int i = pivot + 1; i < right + 1; ++i)
        //    {
        //        currSum += nums[i];
        //        rightSubSum = Math.Max(rightSubSum, currSum);
        //    }

        //    return leftSubSum + rightSubSum;
        //}

        //public int helper(int[] nums, int left, int right)
        //{
        //    if (left == right) return nums[left];

        //    int pivot = (left + right) / 2;

        //    int leftSum = helper(nums, left, pivot);
        //    int rightSum = helper(nums, pivot + 1, right);
        //    int _crossSum = crossSum(nums, left, right, pivot);

        //    return Math.Max(Math.Max(leftSum, rightSum), _crossSum);
        //}

        //public int MaxSubArray(int[] nums)
        //{
        //    return helper(nums, 0, nums.Length - 1);
        //}

        public int MaxSubArray(int[] nums)
        {
            int max = Int32.MinValue;
            int[] sum = new int[nums.Length + 1];
            int cur = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                cur = Math.Max(nums[i] + cur, nums[i]);
                max = Math.Max(max, cur);
            }
            cur = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                cur = Math.Max(nums[i] + cur, nums[i]);
                max = Math.Max(max, cur);
            }
            return max;
        }

        static void Main(string[] args)
        {
            var solution = new MaximumSubarray();
            int[] input = {-2, 1, -3, 4, -1, 2, 1, -5, 4};

            Console.WriteLine(solution.MaxSubArray(input));
        }
    }
}