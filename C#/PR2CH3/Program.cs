using System;
using System.Formats.Asn1;
using System.Threading.Channels;

namespace MyApp
{
    internal class Program
    {
        static void Main()
        {
            //Задание 1
            //Console.WriteLine("Введите число: ");
            //uint enter = Convert.ToUInt32(Console.ReadLine());

            //for (int i = 1; i <= enter; i++)
            //{
            //    Console.Write($"{i} ");
            //}

            //Задание 2
            //Console.WriteLine("Введите число: ");
            //uint enter = Convert.ToUInt32(Console.ReadLine());

            //for (uint i = enter; i >= 1; --i)
            //{
            //    Console.Write($"{i} ");
            //}

            //Задание 3
            //Console.WriteLine("Введите число: ");
            //uint enter = Convert.ToUInt32(Console.ReadLine());

            //for (uint i = 2; i <= enter; i += 2)
            //{

            //    Console.Write($"{i} ");
            //}

            //Задание 4
            //Console.WriteLine("Введите число: ");
            //uint enter = Convert.ToUInt32(Console.ReadLine());

            //for (uint i = 1; i <= enter; i += 2)
            //{

            //    Console.Write($"{i} ");
            //}

            //Задание 5
            //Console.WriteLine("Введите число: ");
            //uint enter = Convert.ToUInt32(Console.ReadLine());
            //uint sum = 0;

            //for (uint i = 1; i <= enter; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine($"Сумма чисел равна {sum}");

            //Задание 6
            //Console.WriteLine("Введите число: ");
            //uint enter = Convert.ToUInt32(Console.ReadLine());
            //uint sum = 0;

            //for (uint i = 2; i <= enter; i += 2)
            //{
            //    sum += i;
            //}
            //Console.WriteLine($"Сумма чисел равна {sum}");

            //Задание 7 
            //Console.WriteLine("Введите число: ");
            //uint enter = Convert.ToUInt32(Console.ReadLine());

            //for (uint i = 1; i <= enter; i++)
            //{
            //    uint proizvod = enter * i;
            //    Console.WriteLine($"{enter} * {i} = {proizvod} ");
            //}

            //Задание 8
            //Console.WriteLine("Введите число: ");
            //uint enter = Convert.ToUInt32(Console.ReadLine());

            //for (uint i = 1; i <= 10; i++)
            //{
            //    uint proizvod = enter * i;
            //    Console.WriteLine($"{enter} * {i} = {proizvod} ");
            //}

            // Задание 9

            //int count = 0;

            //Console.WriteLine("Введите число(0 Заканчивает)");
            //int enter = Convert.ToInt32(Console.ReadLine());

            //while (enter != 0)
            //{
            //    count++;
            //    Console.WriteLine("Введите число (0 Заканчивает)");
            //    enter = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine($"Вы ввели {count} чисел");

            // Задание 10

            //int sum = 0;

            //Console.WriteLine("Введите число(0 Заканчивает)");
            //int enter = Convert.ToInt32(Console.ReadLine());

            //while (enter != 0)
            //{
            //    sum += enter;
            //    Console.WriteLine("Введите число (0 Заканчивает)");
            //    enter = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine($"Сумма чисел равна: {sum}");

            // Задание 11

            //Console.Write("Введите положительное целое число: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int count = 0;

            //if (number == 0)
            //{
            //    count = 1;
            //}
            //else
            //{

            //    while (number > 0)
            //    {
            //        count++;
            //        number /= 10;
            //    }
            //}

            //Console.WriteLine($"Количество цифр: {count}");

            // Задание 12

            //Console.Write("Введите положительное целое число:");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int sum = 0; ;

            //while (number > 0)
            //{
            //    sum += number % 10;
            //    number /= 10;
            //}

            //Console.WriteLine($"Сумма цифр {sum}");

            // Задание 13

            //Console.Write("Введите положительное целое число:");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int sum = 1; ;

            //while (number > 0)
            //{
            //    sum *= number % 10;
            //    number /= 10;
            //}

            //Console.WriteLine($"Произведение цифр {sum}");

            // Задание 14

            //Console.Write("Введите положительное целое число:");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int reversed = 0; 

            //while (number > 0)
            //{
            //    int lastNumber = number % 10;
            //    reversed = (reversed * 10) + lastNumber;
            //    number /= 10;
            //}

            //Console.WriteLine($"Число наоборот: {reversed}");

            // Задание 15

            //Console.Write("Введите положительное целое число:");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int maxNumber = 0;

            //while (number > 0)
            //{
            //    int currentNumber = number % 10;

            //    if (currentNumber > maxNumber)
            //    {
            //        maxNumber = currentNumber;
            //    }

            //    number /= 10;
            //}

            //Console.WriteLine($"Максимальная цифра {maxNumber}");


            // Задание 16

            //Console.Write("Введите положительное целое число:");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int minNumber = 9;

            //if (number == 0)
            //{
            //    minNumber = 0;
            //}

            //while (number > 0)
            //{
            //    int currentNumber = number % 10;

            //    if (currentNumber < minNumber)
            //    {
            //        minNumber = currentNumber;
            //    }

            //    number /= 10;

            //}
            //Console.WriteLine($"Минимальная цифра {minNumber}");

            // Задание 17

            //Console.Write("Введите целое положительное число N: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Введите цифру D (от 0 до 9): ");
            //int d = Convert.ToInt32(Console.ReadLine());

            //int count = 0;

            //if (n == 0 && d == 0)
            //{
            //    count = 1;
            //}

            //while (n > 0)
            //{
            //    int currentNumber = n % 10;

            //    if (currentNumber == d)
            //    {
            //        count++;
            //    }

            //    n /= 10;
            //}

            //Console.WriteLine($"Цифра {d} встречает в числе {d} раз");

            // Задание 18

            //Console.Write("Введите целое положительное число N: ");
            //int ogNumber = Convert.ToInt32(Console.ReadLine());

            //int number = ogNumber;
            //int reversed = 0;

            //while (number > 0)
            //{
            //    int lastNumber = number % 10;
            //    reversed = (reversed * 10) + lastNumber;
            //    number /= 10;
            //}

            //if (ogNumber == reversed)
            //{
            //    Console.WriteLine($"Число {ogNumber} является палиндромом");
            //}
            //else
            //{
            //    Console.WriteLine($"Число {ogNumber} не является палиндромом");
            //}

            // Задание 19

            //Console.Write("Введите целое положительное число N: ");
            //int enter = Convert.ToInt32(Console.ReadLine());

            //long factorial = 1;

            //for( int i = 1; i <= enter; i++)
            //{
            //    factorial *= i;
            //}

            //Console.WriteLine($"{enter}! = {factorial}");

            // Задание 20

            //Console.WriteLine("Введите основание A: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите неотрицательную степень N: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //long result = 1;

            //for (int i = 1; i <= n; i++)
            //{
            //    result *= a;
            //}

            //Console.WriteLine($"{a}^{n} = {result}");

            // Задание 21

            //Console.Write("Введите положительное целое число N: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Делители числа: ");

            //for (int i = 1; i <= n; i++)
            //{

            //    if (n % i == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}

            // Задание 22

            //Console.Write("Введите положительное целое число N: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int count = 0; 

            //for (int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine($"Количество делителей: {count}");

            // Задание 23

            //Console.Write("Введите целое число N (N > 1): ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //bool isPrime = true; // Изначально простое

            //for (int i = 2; i < n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        isPrime = false; 
            //        break;          
            //    }
            //}

            //if (isPrime)
            //{
            //    Console.WriteLine($"{n} - простое");
            //}
            //else
            //{
            //    Console.WriteLine($"{n} - составное");
            //}

            // Заданние 24 

            //Console.Write("Введите целое число N (N > 1): ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Простые числа:");

            //for (int number = 2; number <= n; number++)
            //{
            //    bool isPrime = true;

            //    for (int i = 2; i * i <= number; i++)
            //    {
            //        if (number % i == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }

            //    if(isPrime)
            //    {
            //        Console.Write(number + " ");
            //    }
            //}

            //Console.WriteLine();

            // Задание 25

            //Console.Write("Введите первое число: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Введите второе число: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //int ogA = a;
            //int ogB = b;

            //while (b != 0)
            //{
            //    int temp = b;
            //    b = a % b;
            //    a = temp;
            //}

            //Console.WriteLine($"НОД({ogA}, {ogB}) = {a}");

            // Задание 26

            //Console.WriteLine("Введите число: N ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите первое число Фибоначчи");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите второе число Фибоначчи");
            //int b = Convert.ToInt32(Console.ReadLine());    

            //for (int i = 0; i <= n; i++)
            //{
            //    int fibrez = a + b;
            //    Console.Write(fibrez + " ");
            //    a = b;
            //    b = fibrez;
            //}

            // Задание 27

            //Console.WriteLine("Введите колличество цифор N: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите 1-е число: ");
            //int maxValue = Convert.ToInt32(Console.ReadLine());

            //for (int i = 2; i <= n; i++)
            //{
            //    Console.WriteLine($"Введите {i}-е число: ");
            //    int currentValue = Convert.ToInt32(Console.ReadLine());
            //    if (currentValue > maxValue)
            //    {
            //        maxValue = currentValue;
            //    }
            //}

            //Console.WriteLine($"Максимальное значение: {maxValue}");

            //Задание 28

            //Console.WriteLine("Введите колличество цифор N: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int positiveCount = 0;
            //int negativeCount = 0;
            //int zeroCount = 0;
            //int sum = 0;

            //for(int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Введите {i + 1}-е число: ");
            //    int currentValue = Convert.ToInt32(Console.ReadLine());
            //    if (currentValue > 0)
            //    {
            //        positiveCount++;
            //    }
            //    else if (currentValue < 0)
            //    {
            //        negativeCount++;
            //    }
            //    else
            //    {
            //        zeroCount++;
            //    }
            //    sum += currentValue;
            //}
            //double average = (double)sum / n;

            //Console.WriteLine("Количество положительных чисел: " + positiveCount);
            //Console.WriteLine("Количество отрицательных чисел: " + negativeCount);
            //Console.WriteLine("Количество нулей: " + zeroCount);
            //Console.WriteLine("Среднее арифметическое: " + average);

            // Задание 29

            //Console.WriteLine("Введите ширину прямоугольника: ");
            //int width = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите высоту прямоугольника: ");
            //int height = Convert.ToInt32(Console.ReadLine());

            //for(int i = 0; i < width; i++)
            //{
            //    for(int j = 0; j < height; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            // Задание 30

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {

            //        int product = i * j;

            //        Console.Write("{0,4}", product);
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i} * {j} = {i * j}");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}