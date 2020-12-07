using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_DataStructure_Csharp
{
    class NumberOfIslands
    {
        public int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }

            int count = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    // only for '1'
                    if (grid[i][j] == '1')
                    {
                        // doing dfs
                        count += dfs(i, j, grid);
                    }
                }
            }
            return count;
        }

        int dfs(int row, int col, char[][] grid)
        {
            if (row >= 0 && row < grid.Length && col >= 0 && col < grid[0].Length && grid[row][col] == '1')
            {
                grid[row][col] = '0';  // to make it visited
                dfs(row, col + 1, grid);
                dfs(row + 1, col, grid);
                dfs(row, col - 1, grid);
                dfs(row - 1, col, grid);
                return 1;
            }
            return 0;
        }

        public static void Main()
        {
            NumberOfIslands numberOfIslands = new NumberOfIslands();


            char[][] grid = new char[][]
            {
                new char[] {'1', '0', '1', '1', '0' },
                new char[] {'0', '1', '1', '1', '0' },
                new char[] {'1', '1', '1', '1', '0' },
                new char[] {'1', '1', '1', '0', '1' },
            };

            Console.WriteLine(numberOfIslands.NumIslands(grid));
        }
    }
}
