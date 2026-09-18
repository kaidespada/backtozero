using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2CH4
{
    internal class task25
    {
        public static void Run()
        {
            int[] arrayA = new int[] { 1, 2, 2, 3, 5 };
            int[] arrayB = new int[] { 2, 3, 4, 3 };

            Console.Write("A: ");
            for (int i = 0; i < arrayA.Length; i++) Console.Write(arrayA[i] + " ");
            Console.WriteLine();

            Console.Write("B: ");
            for (int i = 0; i < arrayB.Length; i++) Console.Write(arrayB[i] + " ");
            Console.WriteLine();

            int[] tempResult = new int[arrayA.Length];
            int uniqueCount = 0;

            for (int i = 0; i < arrayA.Length; i++)
            {
                bool inArrayB = false;
                for (int j = 0; j < arrayB.Length; j++)
                {
                    if (arrayA[i] == arrayB[j])
                    {
                        inArrayB = true;
                        break;
                    }
                }

                if (inArrayB)
                {
                    bool isDuplicate = false;
                    for (int j = 0; j < uniqueCount; j++)
                    {
                        if (arrayA[i] == tempResult[j])
                        {
                            isDuplicate = true;
                            break;
                        }
                    }

                    if (!isDuplicate)
                    {
                        tempResult[uniqueCount] = arrayA[i];
                        uniqueCount++;
                    }
                }
            }

            int[] result = new int[uniqueCount];
            for (int i = 0; i < uniqueCount; i++)
            {
                result[i] = tempResult[i];
            }

            Console.Write("Результат: ");
            for (int i = 0; i < result.Length; i++) Console.Write(result[i] + " ");
            Console.WriteLine();
        }
    }
}
