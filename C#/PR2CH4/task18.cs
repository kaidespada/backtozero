using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2CH4
{
    internal class task18
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

            int lastElement = numbers[numbers.Length - 1];

            for (int i = numbers.Length - 1; i > 0; i--)
            {
                numbers[i] = numbers[i - 1];
            }

            Console.WriteLine();
            numbers[0] = lastElement;

            Console.Write("После: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
