using System;

/*
Given a string s and a dictionary of strings wordDict, return true if s can be 
segmented into a space-separated sequence of one or more dictionary words.

Note that the same word in the dictionary may be reused multiple times in the segmentation.
*/

public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        bool canBreak(int start)
        {
            if (start == s.Length)
                return true;
            
            foreach (string word in wordDict)
            {
                if (s.StartsWith(word, start))
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