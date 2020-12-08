using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_DataStructure_Csharp
{
    class TwoSum
    {
        public int[] twoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int comp = target - nums[i];

                if (map.ContainsKey(comp))
                {
                    return new int[] { map[comp], i };
                }
                map.Add(nums[i], i);
            }
            throw new ArgumentException("No result");
        }
        public static void Main()
        {

            var towSum = new TwoSum();

            int[] arr = { 1, 2, 3, 4, 5 };
            
            Console.WriteLine(towSum.twoSum(arr, 5));
        }
    }
}
