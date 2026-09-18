using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2CH4
{
    internal class task27
    {
        public static void Run()
        {
            int[] numbers = new int[] { 1, 7, 3, 6, 5, 6 };

            Console.Write("Массив: ");
            for (int i = 0; i < numbers.Length; i++) Console.Write(numbers[i] + " ");
            Console.WriteLine();

            int totalSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                totalSum += numbers[i];
            }

            int leftSum = 0;
            int equilibriumIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                int rightSum = totalSum - leftSum - numbers[i];

                if (leftSum == rightSum)
                {
                    equilibriumIndex = i;
                    break;
                }

                leftSum += numbers[i];
            }

            Console.WriteLine($"Индекс: {equilibriumIndex}");
        }
    }
}