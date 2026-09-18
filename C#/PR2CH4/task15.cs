using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2CH4
{
    internal class task15
    {
        public static void Run()
        {

            int[] numbers = new int[10];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {

                numbers[i] = Convert.ToInt32(random.Next(-5, 15));
                Console.Write(numbers[i] + " ");

            }

            int max1 = numbers[0];

            int max2 = 0;
            bool hasSecondUnique = false;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max1)
                {
                    max2 = numbers[i];
                    hasSecondUnique = true;
                    break;
                }
            }

            if (!hasSecondUnique)
            {
                Console.WriteLine("Элементы одинаковы");
                return;
            }

            if (max2 > max1)
            {
                int temp = max1;
                max1 = max2;
                max2 = temp;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                int current = numbers[i];

                if (current > max1)
                {
                    max2 = max1;
                    max1 = current;
                }
                else if (current < max1 && current > max2)
                {
                    max2 = current;
                }
            }

            Console.WriteLine("\nПервый максимум: " + max1);
            Console.WriteLine("Второй максимум: " + max2);
        }
    }
}
