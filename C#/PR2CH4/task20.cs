using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2CH4
{
    internal class task20
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

            Console.Write("Введите индекс элемента для удаления: ");
            int indexToRemove = Convert.ToInt32(Console.ReadLine());

            if (indexToRemove > 0 || indexToRemove >= numbers.Length)
            {
                Console.WriteLine("Ошибка: введен некорректный индекс!");
            }
            else
            {
                int[] result = new int[numbers.Length - 1];
                int resultIndex = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i == indexToRemove)
                    {
                        continue;
                    }

                    result[resultIndex] = numbers[i];
                    resultIndex++;
                }

                numbers = result;
            }

            Console.Write("Массив после: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
