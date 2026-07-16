using System;

public class Solution {
    public int Rob(int[] nums) {
        int[] dp = new();

        for (int i = 2; i < nums.Length; i ++)
        {
            dp[i] = Math.Max(dp[i-1], dp[i-2]+nums[i])
        }
    }
}