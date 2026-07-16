using System;

// [1,2,3]
// [4,5,6]
// [7,8,9]

// output: [1,2,3,6,9,8,7,4,5]


public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {

        int top = 0;
        int bottom = matrix.Length - 1;
        int left = 0;
        int right = matrix[0].Length - 1;

        List<int> result = new();
        
        while (top <= bottom && left <= right)
        {
            // esquerda -> direita
            for (int col = left; col <= right; col ++)
            {
                result.Add(matrix[top][col]);
            }

            top++;

            // cima -> baixo
            for (int row = top; row <= bottom; row++)
            {
                result.Add(matrix[row][right]);                
            }

            right--;

            // direita -> esquerda
            // (somente se top <= bottom)
            if (top <= bottom)
            {
                for (int col = right; col >= left; col --)
                {
                    result.Add(matrix[bottom][col]);
                }
                bottom--;
            }

            // baixo -> cima
            // (somente se left <= right)
            if (left <= right)
            {
                for (int row = bottom; row >= top; row --)
                {
                    result.Add(matrix[row][left]);
                }
                left++;
            }
        }

        return result;
    }
}