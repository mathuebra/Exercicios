using System;
using System.Diagnostics.Metrics;

// Given a string s, return the number of palindromic substrings in it.

// two pointer?

public class Solution {
    public int CountSubstrings(string s) {

        void Expand(int left, int right)
        {
            int cont = 0;
            while (s[left] == s[right])
            {
                cont ++;
            }

            if (cont != 0) return 1;
        }

        int left=0, right=0, result = 0;

        for (int i = 1; i < s.Length; i ++)
        {
            int result = Expand(i-1, i+1);
            int result = Expand(i, i+1);
        }
    }
}