using System;

namespace PR2CH4
{
    internal static class task1
    {
        public static void Run()
        {

            Console.Write("Введите ваше имя: ");
            string userName = Console.ReadLine();

            PrintGreeting(userName);

            PrintGreeting("Гость");
        }

        private static void PrintGreeting(string name)
        {
            Console.WriteLine($"Здравствуйте, {name}!");
        }
    }
}