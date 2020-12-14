using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_DataStructure_Csharp
{
    class TwoSum
    {
        public int[] TwoSumSln(int[] nums, int target)
        {

            var dict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var comp = target - nums[i];

                if (dict.ContainsKey(comp))
                {
                    return new int[] { dict[comp], i };
                }
                else dict.Add(nums[i], i);
            }

            return new int[] { 0, 0 };
        }
        public static void _Main()
        {

            var towSum = new TwoSum();

            int[] arr = { 1, 2, 3, 4, 5 };

            Console.WriteLine(towSum.TwoSumSln(arr, 5));
        }
    }
}
