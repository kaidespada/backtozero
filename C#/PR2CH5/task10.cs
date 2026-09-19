using System;
using System.Dynamic;

namespace PR2CH4
{
    internal static class task10
    {
        public static void Run()
        {
            int[] numbers = { 7, -3, 15, 0, 42, 8, -10 };

            GetMinMax(numbers, out int minResult, out int maxResult);

            Console.WriteLine($"Массив: [{string.Join(", ", numbers)}]");
            Console.WriteLine("Минмум: " + minResult);
            Console.WriteLine("Максимум: " + maxResult);
            
        }

        private static void GetMinMax(int[] numbers, out int max, out int min)
        {
            if (numbers == null || numbers.Length == 0)
            {
                min = 0;
                max = 0;
                return;
            }

            min = numbers[0];
            max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }

                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
        }
    }
}