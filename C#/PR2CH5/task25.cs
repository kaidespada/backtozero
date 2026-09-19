using System;

namespace PR2CH4
{
    internal static class task25
    {
        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("\nМеню:\n1 — Приветствие\n2 — Текущая дата\n3 — Сумма двух чисел\n0 — Выход");
                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowGreeting();
                        break;
                    case "2":
                        ShowCurrentDate();
                        break;
                    case "3":
                        CalculateSum();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неверный ввод.");
                        break;
                }
            }
        }

        static void ShowGreeting()
        {
            Console.WriteLine("Привет, пользователь!");
        }

        static void ShowCurrentDate()
        {
            Console.WriteLine($"Текущая дата: {DateTime.Now:dd.MM.yyyy}");
        }

        static void CalculateSum()
        {
            Console.Write("Введите первое число: ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.Write("Введите второе число: ");
            int.TryParse(Console.ReadLine(), out int b);
            Console.WriteLine($"Сумма: {a + b}");
        }
    }
}