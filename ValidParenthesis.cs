using System;

public class Solution {
    public bool IsValid(string s) {
        Stack<char> pilha = new Stack<char>();
        var chars = new Dictionary<char, char>
        {
            { '}', '{' },
            { ']', '[' },
            { ')', '(' }
        };

        foreach (char c in s)
        {
            if (c == '{' || c == '[' || c == '(')
            {
                pilha.Push(c);
            } 
            else if (c == '}' || c == ']' || c == ')')
            {
                if (pilha.Count == 0)
                    return false;

                if (chars[c] == pilha.Peek())
                {
                    pilha.Pop();
                    continue;
                }

                else return false;
            }
        }

        if (pilha.Count != 0) return false;

        return true;
    }
}