using System;

namespace PR2CH4
{
    internal static class task8
    {
        public static void Run()
        {
            int number = 5;
            Console.WriteLine("До: " + number);
            IncreaseByValue(number);
            Console.WriteLine("После by Value: " + number);

            Console.WriteLine("До: " + number);
            IncreaseByRef(ref number);
            Console.WriteLine("После by Ref " + number);
        }

        private static void IncreaseByValue(int value)
        {
            value++;
        }

        private static void IncreaseByRef(ref int value)
        {
            value++;
        }
    }
}