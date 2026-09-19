using System;

namespace PR2CH4
{
    internal static class task11
    {
        public static void Run()
        {
            int minLimit = 0;
            int maxLimit = 100;

            int val1 = 150;
            Console.WriteLine($"Исходное: {val1} (Диапазон: {minLimit}..{maxLimit})");
            Clamp(ref val1, minLimit, maxLimit);
            Console.WriteLine($"После Clamp: {val1}\n"); ;

            int val2 = -50;
            Console.WriteLine($"Исходное: {val2} (Диапазон: {minLimit}..{maxLimit})");
            Clamp(ref val2, minLimit, maxLimit);
            Console.WriteLine($"После Clamp: {val2}\n");

            int val3 = 42;
            Console.WriteLine($"Исходное: {val3} (Диапазон: {minLimit}..{maxLimit})");
            Clamp(ref val3, minLimit, maxLimit);
            Console.WriteLine($"После Clamp: {val3}");

        }

        private static void Clamp(ref int value, int min, int max)
        {
            if (value < min)
            {
                value = min;
            }
            else if (value > max)
            {
                value = max;
            }
        }
    }
}