using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2CH4
{
    internal class task16
    {
        public static void Run()
        {

            int[] numbers = new int[10];
            Random random = new Random();

            Console.Write("Массив: ");

            for (int i = 0; i < numbers.Length; i++)
            {

                numbers[i] = Convert.ToInt16(random.Next(-5, 15));
                Console.Write(numbers[i] + " ");

            }

            bool isSorted = true;

            for (int i = 1; i <  numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    isSorted = false;
                    break;
                }
            }

            Console.WriteLine();

            if (isSorted)
            {
                Console.WriteLine("Упорядочен");
            }
            else
            {
                Console.WriteLine("Не упорядочен");
            }
            
        }
    }
}
