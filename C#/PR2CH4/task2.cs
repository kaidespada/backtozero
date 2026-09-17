using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2CH4
{
    internal class task2
    {
        public static void Run()
        {
            Console.WriteLine("Введите длину массива N");
            int N = Convert.ToInt32 (Console.ReadLine());
            int[] array = new int[N];
            
            for(int i = 0; i < N; i++)
            {
                Console.WriteLine($"Введите элемент {i}");
                array[i] = Convert.ToInt32 (Console.ReadLine());
            }
            Console.WriteLine(" ");
            for (int i = N - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
