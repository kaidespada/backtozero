using System;
using System.Collections.Generic;

namespace Case5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool programRunning = true;

            while (programRunning)
            {
                Console.Clear();

                Console.WriteLine("   ГЛАВНОЕ МЕНЮ   ");
                Console.WriteLine("5 - Учебные тесты");
                Console.WriteLine("6 - Копилка");
                Console.WriteLine("0 - Выход");
                Console.Write("Выберите кейс: ");

                string? caseNumber = Console.ReadLine();

                if (caseNumber == "5")
                {
                    Case5();
                }
                else if (caseNumber == "6")
                {
                    Case6();
                }
                else if (caseNumber == "0")
                {
                    programRunning = false;
                    Console.WriteLine("Программа завершена.");
                }
                else
                {
                    Console.WriteLine(
                        "Неверный ввод. Пожалуйста, выберите 5, 6 или 0."
                    );

                    Console.ReadLine();
                }
            }
        }


        // КЕЙС 5

        static void Case5()
        {
            bool running = true;

            while (running)
            {
                Console.Clear();

                Console.WriteLine(
                    "Вы выбрали кейс 5. Результат двух учебных тестов"
                );

                int min = 0;
                int max = 10;

                int first = 0;
                int second = 0;

                // Ввод первого теста
                Console.Write(
                    $"Введите количество правильных ответов в первом тесте " +
                    $"(от {min} до {max}): "
                );

                while (!int.TryParse(Console.ReadLine(), out first) ||
                       first < min ||
                       first > max)
                {
                    Console.Write(
                        $"Неверный ввод. Пожалуйста, введите число от {min} до {max}: "
                    );
                }

                // Ввод второго теста
                Console.Write(
                    $"Введите количество правильных ответов во втором тесте " +
                    $"(от {min} до {max}): "
                );

                while (!int.TryParse(Console.ReadLine(), out second) ||
                       second < min ||
                       second > max)
                {
                    Console.Write(
                        $"Неверный ввод. Пожалуйста, введите число от {min} до {max}: "
                    );
                }

                // Расчёты
                int totalAnswers = first + second;
                int score = totalAnswers * 5;

                // Результат
                if (score >= 60)
                {
                    Console.WriteLine(
                        $"{first} правильных ответов в первом тесте и " +
                        $"{second} во втором. " +
                        $"Всего {totalAnswers} правильных ответов. " +
                        $"Балл ({first} + {second}) * 5 = {score}. Зачёт"
                    );
                }
                else
                {
                    Console.WriteLine(
                        $"{first} правильных ответов в первом тесте и " +
                        $"{second} во втором. " +
                        $"Всего {totalAnswers} правильных ответов. " +
                        $"Балл ({first} + {second}) * 5 = {score}. " +
                        $"Нужно потренироваться"
                    );
                }

                Console.WriteLine();
                Console.WriteLine("1 - Повторить кейс 5");
                Console.WriteLine("2 - Вернуться в главное меню");
                Console.WriteLine("0 - Выйти из программы");
                Console.Write("Ваш выбор: ");

                string? choice = Console.ReadLine();

                if (choice == "1")
                {
                    // Остаёмся в Case5
                    running = true;
                }
                else if (choice == "2")
                {
                    // Выходим из Case5 и возвращаемся в Main
                    running = false;
                }
                else if (choice == "0")
                {
                    // Здесь тоже возвращаемся в Main
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Неверный выбор.");
                    Console.ReadLine();
                }
            }
        }


        // КЕЙС 6

        static void Case6()
        {
            bool running = true;

            List<string> history = new List<string>();

            while (running)
            {
                Console.Clear();

                Console.WriteLine("===== КЕЙС 6 - КОПИЛКА =====");

                uint max = 10000;
                uint saved = 0;
                uint added = 0;

                // Ввод накопленной суммы
                Console.WriteLine(
                    $"Введите накопленную сумму (до {max}):"
                );

                while (!uint.TryParse(Console.ReadLine(), out saved) ||
                       saved > max)
                {
                    Console.Write(
                        $"Неверный ввод. Пожалуйста, введите число до {max}: "
                    );
                }

                // Ввод пополнения
                Console.WriteLine(
                    $"Введите новое пополнение (до {max}):"
                );

                while (!uint.TryParse(Console.ReadLine(), out added) ||
                       added > max)
                {
                    Console.Write(
                        $"Неверный ввод. Пожалуйста, введите число до {max}: "
                    );
                }

                // Расчёт
                uint total = saved + added;

                string result;

                if (total >= 1000)
                {
                    result =
                        "Было: " + saved + " рублей" +
                        " | Добавили: " + added + " рублей" +
                        " | Всего: " + total + " рублей" +
                        " | Цель достигнута, поздравляем!!!";
                }
                else
                {
                    uint remaining = 1000 - total;

                    result =
                        "Было: " + saved + " рублей" +
                        " | Добавили: " + added + " рублей" +
                        " | Всего: " + total + " рублей" +
                        " | До цели осталось: " + remaining + " рублей";
                }

                Console.WriteLine();
                Console.WriteLine(result);

                // Сохраняем результат
                history.Add(result);

                Console.WriteLine();
                Console.WriteLine("1 - Повторить расчёт");
                Console.WriteLine("2 - Показать историю");
                Console.WriteLine("3 - Вернуться в главное меню");
                Console.WriteLine("0 - Выйти из программы");
                Console.Write("Ваш выбор: ");

                string? choice = Console.ReadLine();

                if (choice == "1")
                {
                    // Повторяем Case6
                    running = true;
                }
                else if (choice == "2")
                {
                    Console.Clear();

                    Console.WriteLine("===== ИСТОРИЯ РАСЧЁТОВ =====");

                    if (history.Count == 0)
                    {
                        Console.WriteLine("История пуста.");
                    }
                    else
                    {
                        for (int i = 0; i < history.Count; i++)
                        {
                            Console.WriteLine(
                                $"{i + 1}. {history[i]}"
                            );
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("Нажмите Enter для продолжения...");
                    Console.ReadLine();

                    // После истории остаёмся в Case6
                    running = true;
                }
                else if (choice == "3")
                {
                    // Возвращаемся в Main
                    running = false;
                }
                else if (choice == "0")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Неверный выбор.");
                    Console.ReadLine();
                }
            }
        }
    }
}
