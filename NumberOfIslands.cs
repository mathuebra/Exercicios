using System;

public class Solution {
    public int NumIslands(char[][] grid) {
        int islands = 0;

        for (int i = 0; i < grid.Length; i ++)
        {
            for (int j = 0; j < grid[0].Length; j ++)
            {
                if (grid[i][j] == '1')
                {
                    islands ++;
                    dfs(grid, i, j);
                }
            }
        }
    }

    void dfs(char[][] grid, int i, int j)
    {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length)
            return ;

        if (grid[i][j] == '0') return ;
        if (grid[i][j] == '1')
        {
            grid[i][j] = '0';

            dfs(grid, i-1, j); // cima
            dfs(grid, i+1, j); // baixo
            dfs(grid, i, j-1); // esquerda
            dfs(grid, i, j+1); // direita
        }
    }
}