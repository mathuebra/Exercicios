using System;


// [0, 1, 0, 1, 2, 3, 4] -> 5

public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        int max_length = 1;

        foreach (int num in nums)
        {
            if (!set.Contains(num-1)) // início de uma nova sequência
            {
                int current = num;
                int length = 1;
            
                while(set.Contains(current+1))
                {
                    current ++;
                    length ++;
                }

                if (length > max_length)
                    max_length = length;
            }
        }

        return max_length;
            
    }
}