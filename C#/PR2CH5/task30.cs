using System;
using System.Linq;

namespace PR2CH4
{
    internal static class task30
    {
        public enum GradeCategory { Excellent, Good, Satisfactory, Unsatisfactory }

        public static void Run()
        {
            Console.Write("Количество студентов: ");
            if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0) return;

            int[] scores = new int[count];

            bool IsInputValid(string input, out int value) => int.TryParse(input, out value);

            for (int i = 0; i < count; i++)
            {
                while (true)
                {
                    Console.Write($"Оценка {i + 1}: ");
                    if (IsInputValid(Console.ReadLine(), out int rawScore))
                    {
                        NormalizeScore(ref rawScore);
                        scores[i] = rawScore;
                        break;
                    }
                }
            }

            GetMinMax(scores, out int min, out int max);

            Console.Write("Порог оценок: ");
            int.TryParse(Console.ReadLine(), out int threshold);

            Console.WriteLine($"\nВсего: {scores.Length}");
            Console.WriteLine($"Мин: {min} ({GetCategoryStr(min)})");
            Console.WriteLine($"Макс: {max} ({GetCategoryStr(max)})");
            Console.WriteLine($"Среднее: {Average(scores):F2}");
            Console.WriteLine($"Выше порога: {CountAbove(scores, threshold, 0)}");
        }

        private static string GetCategoryStr(int score) => score switch
        {
            >= 90 => "Отлично",
            >= 75 => "Хорошо",
            >= 60 => "Удовлетворительно",
            _ => "Неудовлетворительно"
        };

        private static void GetMinMax(int[] arr, out int min, out int max)
        {
            min = arr.Min();
            max = arr.Max();
        }

        private static double Average(params int[] scores) => scores.Length == 0 ? 0 : scores.Average();

        private static void NormalizeScore(ref int score) => score = Math.Clamp(score, 0, 100);

        private static int CountAbove(int[] arr, int limit, int idx)
        {
            if (idx >= arr.Length) return 0;
            return (arr[idx] > limit ? 1 : 0) + CountAbove(arr, limit, idx + 1);
        }
    }
}
