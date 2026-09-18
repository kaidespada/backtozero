using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2CH4
{
    internal class task28
    {
        public static void Run()
        {
            int[,] matrix = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 0, 1, 2 }
            };

            Console.WriteLine("Матрица:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            int maxRowIndex = 0;
            int maxSum = int.MinValue;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int currentRowSum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    currentRowSum += matrix[i, j];
                }

                if (currentRowSum > maxSum)
                {
                    maxSum = currentRowSum;
                    maxRowIndex = i;
                }
            }

            Console.WriteLine($"Максимальная сумма у строки {maxRowIndex}: {maxSum}");
        }
    }
}