using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2CH4
{
    internal class task22
    {
        public static void Run()
        {
            int[] numbers = new int[10];
            Random random = new Random();

            Console.Write("Массив: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-5, 15);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            int[] tempResult = new int[numbers.Length];
            int uniqueCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < uniqueCount; j++)
                {
                    if (numbers[i] == tempResult[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    tempResult[uniqueCount] = numbers[i];
                    uniqueCount++;
                }
            }

            int[] result = new int[uniqueCount];
            for (int i = 0; i < uniqueCount; i++)
            {
                result[i] = tempResult[i];
            }

            Console.Write("Результат: ");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
