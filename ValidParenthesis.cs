using System;

public class Solution {
    public bool IsValid(string s) {
        Stack<char> pilha = new Stack<char>();

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

                if (pilha.Pop() == c)
                    continue;
                else return false;
            }
        }

        return true;
    }
}