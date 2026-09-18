using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2CH4
{
    internal class task12
    {
        public static void Run()
        {

            short[] numbers = new short[10];
            Random random = new Random();

            Console.WriteLine("До: ");
            for (int i = 0; i < numbers.Length; i++)
            {

                numbers[i] = Convert.ToInt16(random.Next(-5, 15));
                Console.Write(numbers[i] + " ");

            }

            for(int i  = 0; i < numbers.Length;i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;

                }
            }

            Console.WriteLine();
            Console.WriteLine("После: ");
            for (int i = 0; i < numbers.Length; i++) {
                Console.Write(numbers[i] + " ");
            }

        }
    }
}
