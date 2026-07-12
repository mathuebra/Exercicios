using System;

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        HashSet<int> hash = new HashSet<int>();

        foreach (int n in nums)
        {
            if (!hash.Contains(n))
                hash.Add(n);
            else return true;
        }

        return false;
    }
}