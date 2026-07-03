using System;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i ++)
        {
            int complement = target - nums[i];

            if (map.ContainsKey(complement))
                return [map[complement], i];

            else map.Add(nums[i], i);

        }
    }
}