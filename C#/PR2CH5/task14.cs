using System;

namespace PR2CH4
{
    internal static class task14
    {
        public static void Run()
        {

            string resultMany = JoinWithSepator(" | ", "C#", "Java", "Python");
            Console.WriteLine($"Результат 1: {resultMany}");

            string resultOne = JoinWithSepator(" | ", "C#");
            Console.WriteLine($"Результат 2: {resultOne}");

            string resultEmpty = JoinWithSepator(" | ");
            Console.WriteLine($"Результат 3: {resultEmpty}");

        }

        private static string JoinWithSepator(string sepator, params string[] parts)
        {
            if (parts == null || parts.Length == 0)
            {
                return "";
            }

            string result = parts[0];

            for (int i = 1; i < parts.Length; i++)
            {
                result += sepator + parts[i];
            }

            return result;

        }
    }
}