using System;
using System.Diagnostics.Metrics;

// Given a string s, return the number of palindromic substrings in it.

public class Solution {
    public int CountSubstrings(string s) {

        int Expand(int left, int right)
        {
            int cont = 0;
            while (
                left >= 0 &&
                right <= s.Length-1 &&
                (s[left] == s[right])
            )
            {
                cont ++;
                left --;
                right ++;
            }

            return cont;
        }

        int result = 0;

        for (int i = 0; i < s.Length; i ++)
        {
            result += Expand(i, i);
            result += Expand(i, i+1);
        }

        return result;
    }
}