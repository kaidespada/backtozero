using System;

namespace PR2CH4
{
    internal static class task15
    {
        public static void Run()
        {
            int num1 = 5;
            Console.WriteLine($"Факториал {num1}! = {Factorial(num1)}"); 

            int num2 = 0;
            Console.WriteLine($"Факториал {num2}! = {Factorial(num2)}"); 

            try
            {
                int num3 = -3;
                Console.WriteLine($"Факториал {num3}! = {Factorial(num3)}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.ResetColor();
            }
        }

        private static int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Факториал определен только для неотрицательных чисел");
            }

            if (n == 0 || n == 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}