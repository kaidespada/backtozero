using System;

namespace PR2CH4
{
    internal static class task2
    {
        public static void Run()
        {

            Console.Write("Введите ширину: ");
            double width = Convert.ToInt64(Console.ReadLine());

            Console.Write("Введите высоту: ");
            double heigh = Convert.ToInt64(Console.ReadLine());

            double area1 = CalculateRectangleArea(width, heigh);
            Console.WriteLine($"Площадь прямоугольника (ввод пользователя): {area1}");


        }

        private static double CalculateRectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}