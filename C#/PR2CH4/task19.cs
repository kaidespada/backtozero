using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2CH4
{
    internal class task19
    {
        public static void Run()
        {

            int[] numbers = new int[10];
            Random random = new Random();

            Console.Write("Массив до: ");

            for (int i = 0; i < numbers.Length; i++)
            {

                numbers[i] = Convert.ToInt16(random.Next(-5, 15));
                Console.Write(numbers[i] + " ");

            }
            Console.WriteLine();

            Console.WriteLine("Введите число K");
            int K = Convert.ToInt32(Console.ReadLine());

            if (K < 0)
            {
                K = (K % numbers.Length) + numbers.Length;
            }

            K = K % numbers.Length;

            int[] result = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                int newIndex = (i + K) % numbers.Length;
                result[newIndex] = numbers[i];
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = result[i];
            }

            Console.Write("Массив после: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
