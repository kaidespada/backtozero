using System;

namespace PR2CH4
{
    internal static class task7
    {
        public static void Run()
        {

            int num1 = 5;
            int num2 = 10;

            Console.WriteLine("До:");
            Console.WriteLine($"num1 = {num1}, num2 = {num2}");

            Swap(ref num1, ref num2);

            Console.WriteLine("После вызова метода Swap:");
            Console.WriteLine($"num1 = {num1}, num2 = {num2}");
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }  
}
