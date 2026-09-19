using System;

namespace PR2CH4
{
    internal static class task16
    {
        public static void Run()
        {
            int num1 = 5; 
            Console.WriteLine($"Сумма чисел от 1 до {num1} = {SumToN(num1)}");

            int num2 = 1;
            Console.WriteLine($"Сумма чисел от 1 до {num2} = {SumToN(num2)}");

            try
            {
                int num3 = 0;
                Console.WriteLine($"Сумма чисел от 1 до {num3} = {SumToN(num3)}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.ResetColor();
            }
        }

        private static int SumToN(int n)
        {
            if (n < 1)
            {
                throw new ArgumentException("Число n должно быть > или = 1");
            }

            if (n == 1)
            {
                return 1;
            }

            return n + SumToN(n - 1);
        }
    }
}