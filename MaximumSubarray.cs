using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_DataStructure_Csharp
{
    class MaximumSubarray
    {
        public int crossSum(int[] nums, int left, int right, int pivot)
        {
            if (left == right) return nums[left];

            int leftSubSum = int.MinValue;
            int rightSubSum = int.MinValue;
            int currSum = 0;

            for (int i = pivot; i > left - 1; --i)
            {
                currSum += nums[i];
                leftSubSum = Math.Max(leftSubSum, currSum);
            }

            currSum = 0;

            for (int i = pivot + 1; i < right + 1; ++i)
            {
                currSum += nums[i];
                rightSubSum = Math.Max(rightSubSum, currSum);
            }

            return leftSubSum + rightSubSum;
        }

        public int helper(int[] nums, int left, int right)
        {
            if (left == right) return nums[left];

            int pivot = (left + right) / 2;

            int leftSum = helper(nums, left, pivot);
            int rightSum = helper(nums, pivot + 1, right);
            int _crossSum = crossSum(nums, left, right, pivot);

            return Math.Max(Math.Max(leftSum, rightSum), _crossSum);
        }

        public int MaxSubArray(int[] nums)
        {
            return helper(nums, 0, nums.Length - 1);
        }
    }
}