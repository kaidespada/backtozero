using System;

namespace PR2CH4
{
    internal static class task3
    {
        public static void Run()
        {

            Console.Write("Введите первое значение: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе значение: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье значение: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int result = MaxOfThree(a, b, c);
            Console.WriteLine("Максимальное значение " + result);
        }

        private static int MaxOfThree(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
    }
}