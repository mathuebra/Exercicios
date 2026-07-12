using System;
using System.Diagnostics.Contracts;

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new ();

        foreach (string s in strs)
        {
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            string sorted = new string(chars);

            if (!dict.ContainsKey(sorted))
            {
                dict[sorted] = new List<string>();
            }

            dict[sorted].Add(s);
        }

        return dict.Values.ToList<IList<string>>();
    }
}