using System;

namespace PR2CH4
{
    internal static class task23
    {
        public static void Run()
        {
            try
            {
                Console.Write("Введите номер месяца (1-12): ");
                int month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Год високосный? (true/false): ");
                bool isLeap = Convert.ToBoolean(Console.ReadLine());

                int days = DaysInMonth(month, isLeap);
                Console.WriteLine($"Количество дней в этом месяце: {days}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static int DaysInMonth(int month, bool isLeapYear)
        {
            return month switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => isLeapYear ? 29 : 28,
                _ => throw new ArgumentOutOfRangeException(nameof(month), "Номер месяца должен быть от 1 до 12.")
            };
        }
    }
}