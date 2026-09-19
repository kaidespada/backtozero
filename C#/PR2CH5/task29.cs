using System;
using System.Linq;

namespace PR2CH4
{
    internal static class task29
    {
        public enum Command
        {
            Help,
            Sum,
            Average,
            Factorial,
            Exit
        }

        public static void Run()
        {
            bool isRunning = true;
            ShowHelp();

            while (isRunning)
            {
                Console.Write("\nВведите команду: ");
                string input = Console.ReadLine()?.Trim();

                if (Enum.TryParse(input, ignoreCase: true, out Command command))
                {
                    switch (command)
                    {
                        case Command.Help:
                            ShowHelp();
                            break;
                        case Command.Sum:
                            ExecuteSum();
                            break;
                        case Command.Average:
                            ExecuteAverage();
                            break;
                        case Command.Factorial:
                            ExecuteFactorial();
                            break;
                        case Command.Exit:
                            isRunning = false;
                            Console.WriteLine("Выход из программы.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Некорректная команда. Введите 'Help' для просмотра списка команд.");
                }
            }
        }

        private static void ShowHelp()
        {
            Console.WriteLine("\nДоступные команды:");
            Console.WriteLine("Help      — Показать список команд");
            Console.WriteLine("Sum       — Посчитать сумму чисел");
            Console.WriteLine("Average   — Посчитать среднее арифметическое");
            Console.WriteLine("Factorial — Посчитать факториал числа");
            Console.WriteLine("Exit      — Выйти из программы");
        }

        private static void ExecuteSum()
        {
            int[] numbers = ReadNumbers();
            Console.WriteLine($"Сумма: {CalculateSum(numbers)}");
        }

        private static void ExecuteAverage()
        {
            int[] numbers = ReadNumbers();
            if (numbers.Length == 0)
            {
                Console.WriteLine("Массив чисел пуст.");
                return;
            }
            Console.WriteLine($"Среднее значение: {CalculateAverage(numbers)}");
        }

        private static void ExecuteFactorial()
        {
            Console.Write("Введите неотрицательное целое число: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                Console.WriteLine($"Факториал {n} = {CalculateFactorial(n)}");
            }
            else
            {
                Console.WriteLine("Ошибка: введено некорректное или отрицательное число.");
            }
        }

        private static int CalculateSum(params int[] numbers)
        {
            return numbers.Sum();
        }

        private static double CalculateAverage(params int[] numbers)
        {
            return numbers.Average();
        }

        private static long CalculateFactorial(int n)
        {
            if (n == 0 || n == 1) return 1;
            return n * CalculateFactorial(n - 1);
        }

        private static int[] ReadNumbers()
        {
            Console.Write("Введите числа через пробел: ");
            string input = Console.ReadLine() ?? "";
            return input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => int.TryParse(s, out int val) ? val : (int?)null)
                        .Where(v => v.HasValue)
                        .Select(v => v.Value)
                        .ToArray();
        }
    }
}
