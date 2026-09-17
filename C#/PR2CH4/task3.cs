using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2CH4
{
    internal class task3
    {
        public static void Run()
        {
            int[] numbers = new int[10];
            Random random = new Random();
            int summa = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                numbers[i] = random.Next(-5, 15);
                Console.Write(numbers[i] + " ");
                summa += numbers[i];
            }
            Console.WriteLine(" ");
            Console.WriteLine("Сумма: " + summa);

        }
    }
}
