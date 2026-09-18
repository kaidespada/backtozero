using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2CH4
{
    internal class task13
    {
        public static void Run()
        {
            int minIndex = 0;
            int maxIndex = 0;

            short[] numbers = new short[10];
            Random random = new Random();

            Console.Write("До: ");

            for (int i = 0; i < numbers.Length; i++)
            {

                numbers[i] = Convert.ToInt16(random.Next(-5, 15));
                Console.Write(numbers[i] + " ");

            }

            Console.WriteLine();

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[minIndex])
                {
                    minIndex = i;
                }

                if (numbers[i] > numbers[maxIndex])
                {
                    maxIndex = i;
                }
            }

            short temp = numbers[minIndex];
            numbers[minIndex] = numbers[maxIndex];
            numbers[maxIndex] = temp;

            Console.Write("После: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

        }
    }
}
