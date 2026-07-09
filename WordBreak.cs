using System;
using System.Text.RegularExpressions;

/*
Given a string s and a dictionary of strings wordDict, return true if s can be 
segmented into a space-separated sequence of one or more dictionary words.

Note that the same word in the dictionary may be reused multiple times in the segmentation.
*/

public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {

        bool Matches(int start, string word)
        {
            if (start + word.Length > s.Length)
                return false;

            for (int i = 0; i < word.Length; i++)
            {
                if (s[start + i] != word[i])
                    return false;
            }

            return true;
        }

        bool canBreak(int start)
        {
            if (start == s.Length)
                return true;
            
            foreach (string word in wordDict)
            {
                if (Matches(start, word))
                {
                    if (canBreak(start + word.Length))
                        return true;
                }
            }

            return false;
        }

        return canBreak(0);
    }
}