using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2CH4
{
    internal class task23
    {
        public static void Run()
        {
            int[] numbers = new int[10];
            Random random = new Random();

            Console.Write("Массив: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-5, 15);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            int mostFrequentValue = numbers[0];
            int maxCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        currentCount++;
                    }
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    mostFrequentValue = numbers[i];
                }
            }

            Console.WriteLine($"Элемент: {mostFrequentValue}");
            Console.WriteLine($"Количество: {maxCount}");
        }
    }
}