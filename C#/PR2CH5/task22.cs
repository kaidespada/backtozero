using System;

namespace PR2CH4
{
    internal static class task22
    {
        public static void Run()
        {
            try
            {
                Console.Write("Введите первое число: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите операцию (+, -, *, /): ");
                char op = Convert.ToChar(Console.ReadLine());

                Console.Write("Введите второе число: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = Calculate(num1, num2, op);
                Console.WriteLine($"Результат: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введено некорректное число или символ операции.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static double Calculate(double a, double b, char operation)
        {
            return operation switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                '/' => b == 0 ? throw new DivideByZeroException("Деление на ноль невозможно.") : a / b,
                _ => throw new InvalidOperationException($"Неизвестная операция: '{operation}'.")
            };
        }
    }
}