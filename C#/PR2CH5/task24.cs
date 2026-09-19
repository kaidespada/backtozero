using System;

namespace PR2CH4
{
    internal static class task24
    {
        public static void Run()
        {
            Console.Write("Введите температуру: ");
            if (int.TryParse(Console.ReadLine(), out int temp))
            {
                string category = temp switch
                {
                    < -10 => "мороз",
                    >= -10 and < 15 => "холодно",
                    >= 15 and < 30 => "тепло",
                    >= 30 => "жарко"
                };

                Console.WriteLine(category);
            }
        }
    }
}