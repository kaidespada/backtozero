using System;

namespace PR2CH4
{
    internal static class task17
    {
        public static void Run()
        {
            int num1 = 1234;
            Console.WriteLine($"Сумма цифр числа {num1} = {SumDigits(num1)}");

            int num2 = -508;
            Console.WriteLine($"Сумма цифр числа {num2} = {SumDigits(num2)}");

            int num3 = 7;
            Console.WriteLine($"Сумма цифр числа {num3} = {SumDigits(num3)}");
        }

        private static int SumDigits(int number)
        {
            if (number < 0)
            {
                number = -number;
            }

            if (number < 10)
            {
                return number;
            }

            return (number % 10) + SumDigits(number / 10);
        }
    }
}