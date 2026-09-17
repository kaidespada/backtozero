using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2CH4
{
    internal class task9
    {
        public static void Run()
        {
            int[] numbers = new int[10];
            Random random = new Random();
            int XIndex = 0;

            Console.WriteLine("Введите число X: ");
            int X = Convert.ToInt32(Console.ReadLine());

            Console.Write("Массив: ");
            for (int i = 0; i < numbers.Length; i++)
            {

                numbers[i] = random.Next(-5, 15);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            bool found = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == X)
                {
                    XIndex = i;
                    found = true;
                    break;
                    
                }                
            }

            if (found)
            {
                Console.WriteLine("Входит");
                Console.WriteLine("Индекс: " + XIndex);
            }
            else
            {
                Console.WriteLine("Не входит");
            }

        }
    }
}
