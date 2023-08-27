// 30. Multidimensional arrays
using System;

namespace MultidimensionalArrays {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine();
            // Arrays can also contain other arrays as their elements.
            // This can be done as follows:
            int[,] grid = new int[3, 3];
            // int[,] grid = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            grid[0, 0] = 1;
            grid[0, 1] = 2;
            grid[0, 2] = 3;
            grid[1, 0] = 4;
            grid[1, 1] = 5;
            grid[1, 2] = 6;
            grid[2, 0] = 7;
            grid[2, 1] = 8;
            grid[2, 2] = 9;

            for (int i = 0; i < grid.GetLength(0); i++) {

                for (int j = 0; j < grid.GetLength(1); j++) {
                    Console.Write(grid[i, j]);
                }

                Console.WriteLine("");
            }

            Console.ReadKey();
            Console.WriteLine();
        }
    }
}