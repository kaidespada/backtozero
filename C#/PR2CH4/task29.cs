using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2CH4
{
    internal class task29
    {
        public static void Run()
        {
            int[,] matrix = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine("Матрица 3x3:");
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            int mainDiagonalSum = 0;
            int sideDiagonalSum = 0;

            for (int i = 0; i < n; i++)
            {
                mainDiagonalSum += matrix[i, i];
                sideDiagonalSum += matrix[i, n - 1 - i];
            }

            Console.WriteLine($"Главная: {mainDiagonalSum}");
            Console.WriteLine($"Побочная: {sideDiagonalSum}");
        }
    }
}