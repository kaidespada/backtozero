using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2CH4
{
    internal class task26
    {
        public static void Run()
        {
            int[] numbers = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            Console.Write("Массив: ");
            for (int i = 0; i < numbers.Length; i++) Console.Write(numbers[i] + " ");
            Console.WriteLine();

            int maxSoFar = numbers[0];
            int maxEndingHere = numbers[0];
            int start = 0, end = 0, tempStart = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxEndingHere + numbers[i])
                {
                    maxEndingHere = numbers[i];
                    tempStart = i;
                }
                else
                {
                    maxEndingHere += numbers[i];
                }

                if (maxEndingHere > maxSoFar)
                {
                    maxSoFar = maxEndingHere;
                    start = tempStart;
                    end = i;
                }
            }

            Console.WriteLine($"Максимальная сумма: {maxSoFar}");

            Console.Write("Фрагмент: ");
            for (int i = start; i <= end; i++) Console.Write(numbers[i] + " ");
            Console.WriteLine();
        }
    }
}