using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2CH4
{
    internal class task14
    {
        public static void Run()
        {

            int[] numbers = new int[10];
            Random random = new Random();

            Console.Write("До: ");

            for (int i = 0; i < numbers.Length; i++)
            {

                numbers[i] = Convert.ToInt16(random.Next(-5, 15));
                Console.Write(numbers[i] + " ");

            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int j = numbers.Length - 1 - i;

                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }

            Console.WriteLine("После: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
