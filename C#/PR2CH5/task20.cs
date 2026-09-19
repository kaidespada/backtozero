using System;

namespace PR2CH4
{
    internal static class task20
    {
        public static void Run()
        {
            int[] sampleArray = { 5, 12, -3, 8, 0, 15, 4 };
            PrintArrayStatistics(sampleArray);
        }

        static void PrintArrayStatistics(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                Console.WriteLine("Массив пуст или равен null");
                return;
            }

            int CalculateSum()
            {
                int sum = 0;
                foreach (int num in numbers)
                {
                    sum += num;
                }
                return sum;
            }

            double CalculateAverage(int sum)
            {
                return (double)sum / numbers.Length;
            }

            int totalSum = CalculateSum();
            double average = CalculateAverage(totalSum);

            int min = numbers[0];
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min) min = numbers[i];
                if (numbers[i] > max) max = numbers[i];
            }

            Console.WriteLine($"Длина: {numbers.Length}");
            Console.WriteLine($"Сумма: {totalSum}");
            Console.WriteLine($"Среднее: {average:F2}");
            Console.WriteLine($"Минимум: {min}");
            Console.WriteLine($"Максимум: {max}");
        }
    }
}