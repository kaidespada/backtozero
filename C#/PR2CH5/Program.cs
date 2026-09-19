using System;
using System.Threading.Tasks;

namespace PR2CH4
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Введите номер задачи (1-30, 0-выход): ");
                if (!int.TryParse(Console.ReadLine(), out int num) || num == 0) break;

                Console.Clear();
                switch (num)
                {
                    case 1: task1.Run(); break;
                    case 2: task2.Run(); break;
                    case 3: task3.Run(); break;
                    case 4: task4.Run(); break;
                    case 5: task5.Run(); break;
                    case 6: task6.Run(); break;
                    case 7: task7.Run(); break;
                    case 8: task8.Run(); break;
                    case 9: task9.Run(); break;
                    case 10: task10.Run(); break;
                    case 11: task11.Run(); break;
                    case 12: task12.Run(); break;
                    case 13: task13.Run(); break;
                    case 14: task14.Run(); break;
                    case 15: task15.Run(); break;
                    case 16: task16.Run(); break;
                    case 17: task17.Run(); break;
                    case 18: task18.Run(); break;
                    case 19: task19.Run(); break;
                    case 20: task20.Run(); break;
                    case 21: task21.Run(); break;
                    case 22: task22.Run(); break;
                    case 23: task23.Run(); break;
                    case 24: task24.Run(); break;
                    //case 25: task25.Run(); break;
                    //case 26: task26.Run(); break;
                    //case 27: task27.Run(); break;
                    //case 28: task28.Run(); break;
                    //case 29: task29.Run(); break;
                    //case 30: task30.Run(); break;

                    default: Console.WriteLine("Нет такой задачи"); break;
                }
                Console.WriteLine("\nНажмите клавишу...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
