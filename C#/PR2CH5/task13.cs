using System;

namespace PR2CH4
{
    internal static class task13
    {
        public static void Run()
        {
            double avgMany = AVG(10.5, 20.0, 30.5);
            Console.WriteLine($"Среднее (10.5, 20.0, 30.5) = {avgMany:F2}");

            double avgOne = AVG(7.0);
            Console.WriteLine($"Среднее (7.0) = {avgOne}");

            double avgEmpty = AVG();
            Console.WriteLine($"Среднее без аргументов () = {avgEmpty}");

        }

        private static double AVG(params double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0;
            }

            double sum = 0;
            foreach (double val in values)
            {
                sum += val;
            }

            return sum / values.Length;
        }
    }
}