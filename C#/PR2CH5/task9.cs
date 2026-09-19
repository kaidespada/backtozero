using System;

namespace PR2CH4
{
    internal static class task9
    {
        public static void Run()
        {
            Console.WriteLine("Введите строку для преобразования в число: ");
            string input = Console.ReadLine();
            
            if (TryReadInt(input, out int resultNumber))
            {
                Console.WriteLine("Введено корректное число: " + resultNumber);
            }
            else
            {
                Console.WriteLine("Ошибка: Введенная строка не корректна.");
            }

        }

        private static bool TryReadInt(string text, out int number)
        {
            return int.TryParse(text, out number);
        }
    }
}