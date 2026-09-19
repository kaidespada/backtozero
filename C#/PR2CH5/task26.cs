using System;

namespace PR2CH4
{
    internal static class task26
    {
        public enum DayOfWeekSimple
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public static void Run()
        {
            Console.Write("Введите номер дня недели (1-7): ");
            if (int.TryParse(Console.ReadLine(), out int dayNum) && dayNum >= 1 && dayNum <= 7)
            {
                // число (1-7) к элементам enum (0-6)
                DayOfWeekSimple day = (DayOfWeekSimple)(dayNum - 1);

                bool weekend = IsWeekend(day);
                Console.WriteLine(weekend ? "Выходной" : "Будний день");
            }
            else
            {
                Console.WriteLine("Неверный ввод.");
            }
        }

        private static bool IsWeekend(DayOfWeekSimple day)
        {
            return day switch
            {
                DayOfWeekSimple.Saturday or DayOfWeekSimple.Sunday => true,
                _ => false
            };
        }
    }
}
