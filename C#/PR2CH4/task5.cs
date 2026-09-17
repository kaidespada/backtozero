using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2CH4
{
    internal class task5
    {
        public static void Run()
        {
            int[] numbers = new int[10];
            Random random = new Random();
            int min = random.Next(0, numbers.Length);

            for (int i = 0; i < numbers.Length; i++)
            {

                numbers[i] = random.Next(-5, 15);
                Console.Write(numbers[i] + " ");
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("Минимум: " + min);

        }
    }
}
