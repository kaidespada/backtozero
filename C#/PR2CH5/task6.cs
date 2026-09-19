using System;

namespace PR2CH4
{
    internal static class task6
    {
        public static void Run()
        {

            Console.Write("Введите делимое: ");
            double a= Convert.ToInt64(Console.ReadLine());

            Console.Write("Введите делитель: ");
            double b = Convert.ToInt64(Console.ReadLine());

            if(TryDivide(a, b, out double divResult))
            {
                Console.WriteLine("Результат деления: " + divResult);
            }
            else
            {
                Console.WriteLine("Ошибка: делить на ноль нельзя");
            }
        }

        private static bool TryDivide(double a, double b, out double result)
        {
            if (b == 0)
            {
                result = 0;
                return false;
            }
            else
            {
                result = a / b;
                return true;
            }
        }
    }
}