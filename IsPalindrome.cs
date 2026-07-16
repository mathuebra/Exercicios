using System;
public class Solution {
    public bool IsPalindrome(string s) {
        int start = 0, end = s.Length -1;
        bool flag;

        s = s.Trim().ToLower();

        while (start < end)
        {
            if (Char.IsNumber(s[start])) start ++;
            if (Char.IsNumber(s[end])) end --;
            if (start >= end) break;

            if (s[start] != s[end]) return false;

            start ++;
            end --;
        }

        return true;
    }
}

class Program
{
    static void Main()
    {
        Solution solution = new Solution();

        Console.WriteLine(solution.IsPalindrome("A man, a plan, a canal: Panama"));
    }
}