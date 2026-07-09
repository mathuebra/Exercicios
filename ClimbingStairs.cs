using System;

public class Solution {
    private Dictionary<int, int> memo = new();

    public int ClimbStairs(int n) {
        // tem n degraus
        // pode subir 1 ou 2 degraus
        // ou seja, o último degrau foi alcançado com n-1 ou n-2

        if (n <= 1) return 1;



        return ClimbStairs(n-1) + ClimbStairs(n-2);
    }
}