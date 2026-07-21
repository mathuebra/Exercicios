using System;
using System.IO.Pipelines;
using System.Runtime.InteropServices;

public class Solution {
    public int UniquePaths(int m, int n) {
        int[][] grid = new int[m][n];

        grid[0][0] = 1; // apenas 1 jeito de chegar à célula 1

        Array.Fill(grid[0], 1); // preenche primeira linha com 1, pois apenas 1 jeito de chegar nela
        
        foreach (var row in grid)
        {
            row[0] = 1; // primeira coluna
        }

        for (int i = 0; i < m; i ++)
        {
            for (int j = 0; j < n; j ++)
            {
                
            }
        }


        return 


    }

    int factorial(int x)
    {
        if (x == 1) return 1;
        return x * x-1;
    }
}