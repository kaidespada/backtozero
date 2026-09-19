using System;

namespace PR2CH4
{
    internal static class task19
    {
        public static void Run()
        {
            int userScore = ReadScore();
            Console.WriteLine($"Ваш балл: {userScore}");
        }

        static int ReadScore()
        {
            int score;

            bool IsValid(int value)
            {
                return value >= 0 && value <= 100;
            }

            do
            {
                Console.Write("Введите балл (от 0 до 100): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out score))
                {
                    if (!IsValid(score))
                    {
                        Console.WriteLine("Ошибка: балл должен быть в диапазоне от 0 до 100.");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: введено не число. Попробуйте еще раз.");
                    score = -1;
                }

            } while (!IsValid(score));

            return score;
        }
    }
}