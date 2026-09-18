using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2CH4
{
    internal class task17
    {
        public static void Run()
        {

            int[] numbers = new int[10];
            Random random = new Random();

            Console.Write("Массив: ");

            for (int i = 0; i < numbers.Length; i++)
            {

                numbers[i] = Convert.ToInt16(random.Next(-5, 15));
                Console.Write(numbers[i] + " ");

            }

            int maxIndex = 0; 
            int minIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[minIndex])
                {
                    minIndex = i;
                }
                if (numbers[i] > numbers[maxIndex])
                {
                    maxIndex = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Первый минимум: {numbers[minIndex]} (индекс {minIndex})");
            Console.WriteLine($"Первый максимум: {numbers[maxIndex]} (индекс {maxIndex})");

            int start, end;

            if (minIndex < maxIndex)
            {
                start = minIndex;
                end = maxIndex;
            }

            else
            {
                start = maxIndex;
                end = minIndex;
            }

            int sum = 0;
            for(int i = start + 1; i < end; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine($"Сумма элементов между ними: {sum}");
        }
    }
}
