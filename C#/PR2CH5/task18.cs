using System;

namespace PR2CH4
{
    internal static class task18
    {
        public static void Run()
        {

            int[] numbers = { 3, 5, 7, 9, 11 };

            Console.WriteLine(Contains(numbers, 7));  
            Console.WriteLine(Contains(numbers, 4));
        }

        private static bool Contains(int[] array, int value, int index = 0)
        {
            if (index >= array.Length)
            {
                return false;
            }

            if (array[index] == value)
            {
                return true;
            }

            return Contains(array, value, index + 1);
        }
    }
}