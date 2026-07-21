using System;
using System.Data;

// matrix = [[1,2,3],[4,5,6],[7,8,9]]
// output = [[7,4,1],[8,5,2],[9,6,3]]

public class Solution {
    public void Rotate(int[][] matrix) {
        for (int i = 0; i < matrix.Length; i ++)
        {
            for (int j = i+1; j < matrix[0].Length; j ++)
            {
                int holder = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = holder;
            }
        }
  
        foreach (var row in matrix)
        {
            Array.Reverse(row);
        }
    }
}