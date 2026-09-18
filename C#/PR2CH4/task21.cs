using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2CH4
{
    internal class task21
    {
        public static void Run()
        {
            int[] numbers = new int[10];
            Random random = new Random();

            Console.Write("До: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-5, 15);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine(" ");

            int swapCount = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;

                        swapCount++; 
                    }
                }
            }

            Console.Write("После: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Количество выполненных обменов: {swapCount}");
        }
    }
}
