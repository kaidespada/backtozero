using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2CH4
{
    internal class task24
    {
        public static void Run()
        {
            // Для демонстрации слияния создаем сразу отсортированные вручную массивы
            int[] arrayA = new int[] { 1, 4, 7, 10, 12 };
            int[] arrayB = new int[] { 2, 3, 9, 11, 15 };

            Console.Write("A: ");
            for (int i = 0; i < arrayA.Length; i++) Console.Write(arrayA[i] + " ");
            Console.WriteLine();

            Console.Write("B: ");
            for (int i = 0; i < arrayB.Length; i++) Console.Write(arrayB[i] + " ");
            Console.WriteLine();

            int[] arrayC = new int[arrayA.Length + arrayB.Length];
            int iA = 0, iB = 0, iC = 0;

            while (iA < arrayA.Length && iB < arrayB.Length)
            {
                if (arrayA[iA] <= arrayB[iB])
                {
                    arrayC[iC] = arrayA[iA];
                    iA++;
                }
                else
                {
                    arrayC[iC] = arrayB[iB];
                    iB++;
                }
                iC++;
            }

            while (iA < arrayA.Length)
            {
                arrayC[iC] = arrayA[iA];
                iA++;
                iC++;
            }

            while (iB < arrayB.Length)
            {
                arrayC[iC] = arrayB[iB];
                iB++;
                iC++;
            }

            Console.Write("C: ");
            for (int i = 0; i < arrayC.Length; i++) Console.Write(arrayC[i] + " ");
            Console.WriteLine();
        }
    }
}