using System;

namespace PR2CH4
{
    internal static class task12
    {
        public static void Run()
        {
            int resultMany = Sum(1, 2, 3, 4, 5);
            Console.WriteLine($"Сумма (1, 2, 3, 4, 5) = {resultMany}");

            int resultOne = Sum(10);
            Console.WriteLine($"Сумма (10) = {resultOne}");

            int resultEmpty = Sum();
            Console.WriteLine($"Сумма без аргументов () = {resultEmpty}");
        }

        private static int Sum(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}