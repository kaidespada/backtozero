using System;

namespace PR2CH4
{
    internal static class task5
    {
        public static void Run()
        {
            Console.Write("Введите набранные баллы (0-100): ");
            int userScore = Convert.ToInt32(Console.ReadLine());

            string grade = GetGrade(userScore);

            Console.WriteLine($"Результат: {grade}");
        }

        private static string GetGrade(int score)
        {
            if (score < 0 || score > 100)
            {
                return "Ошибка: неверное количество баллов!";
            }

            if (score >= 90)
            {
                return "Отлично"; 
            }
            else if (score >= 74)
            {
                return "Хорошо"; 
            }
            else if (score >= 60)
            {
                return "Удовлетворительно"; 
            }
            else
            {
                return "Неудовлетворительно"; 
            }
        }
    }
}
