using System;

public class Solution {
    public int HammingWeight(int n) {
        string str = ConvertToBinary(n);
        int count = 0;

        if (n == 0) return 0;

        foreach (char c in str)
        {
            if (c == '1')
                count ++;
        }

        return count;
    }

    string ConvertToBinary(int n)
    {
        string s = "";

        while (n > 0)
        {
            if (n % 2 == 1) s += "1";
            else s += "0";

            n = n/2;
        }

        char[] temp = s.ToCharArray();
        Array.Reverse(temp);

        return new string(temp);
    }
}

