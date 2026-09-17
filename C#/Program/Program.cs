using System;
using System.Reflection.Metadata;


namespace project
{
    class Program
    {
        static void Main()
        {
            // Задача 1
            //Console.WriteLine("Как к вам обращаться?");
            //string i = Console.ReadLine();
            //Console.WriteLine($"Привет, {i}!");


            // Задача 2

            //int min = -1000;
            //int max = 1000;
            //Console.Write($"Введите число от {min} до {max}: ");
            //int i = Convert.ToInt32(Console.ReadLine());
            //if (i < min || i > max)
            //{
            //    Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //}
            //else
            //{
            //    Console.WriteLine($"Вы ввели корректное число: {i}");
            //    int back = i - 1;
            //    int next = i + 1;
            //    Console.WriteLine($"Предыдущее число: {back}, Следующее число: {next}");

            //}


            // Задача 3

            //int min = -1000;
            //int max = 1000;
            //Console.Write($"Введите первое число от {min} до {max}: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a < min || a > max)
            //{
            //    Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //}
            //else
            //{
            //    Console.WriteLine($"Вы ввели корректное число: {a}");
            //    Console.Write($"Введите второе число от {min} до {max}: ");
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    if (b < min || b > max)
            //    {
            //        Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Вы ввели корректное число: {b}");
            //        int sum = a + b;
            //        int difference = a - b;
            //        int product = a * b;
            //        double quotient = (double)a / b;
            //        Console.WriteLine($"Сумма: {sum}");
            //        Console.WriteLine($"Разность: {difference}");
            //        Console.WriteLine($"Произведение: {product}");
            //        Console.WriteLine($"Частное: {quotient}");

            //    }
            //}


            // Задача 4

            //int min = 1;
            //int max = 1000;
            //Console.Write($"Введите первое число от {min} до {max}: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a < min || a > max)
            //{
            //    Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //}
            //else
            //{
            //    Console.WriteLine($"Вы ввели корректное число: {a}");
            //    Console.Write($"Введите второе число от {min} до {max}: ");
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    if (b < min || b > max)
            //    {
            //        Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Вы ввели корректное число: {b}");
            //        int area = a * b;
            //        int perimetr = 2 * (a + b);
            //        Console.WriteLine($"Площадь: {area}");
            //        Console.WriteLine($"Периметр: {perimetr}");

            //    }
            //}

            // Задача 5

            //int min = 0;
            //int max = 100;
            //Console.Write($"Введите первое число от {min} до {max}: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a < min || a > max)
            //{
            //    Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //}
            //else
            //{
            //    Console.WriteLine($"Вы ввели корректное число: {a}");
            //    Console.Write($"Введите второе число от {min} до {max}: ");
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    if (b < min || b > max)
            //    {
            //        Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Вы ввели корректное число: {b}");
            //        int tetrad = a * 50;
            //        int ruchka = b * 20;
            //        int summ = tetrad + ruchka;
            //        Console.WriteLine($"Стоимость: {summ}");

            //    }
            //}

            // Задача 6
            //int min = 0;
            //int max = 120;
            //Console.Write($"Введите первое число от {min} до {max}: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a < min || a > max)
            //{
            //    Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //}
            //else
            //{
            //    Console.WriteLine($"Вы ввели корректное число: {a}");
            //    int month = a * 12;
            //    Console.WriteLine($"Количество месяцев: {month}");

            //}

            // Задача 7
            /*
            int min = 0;
            int max = 10000;
            Console.Write($"Введите первое число от {min} до {max}: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < min || a > max)
            {
                Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            }
            else
            {
                Console.WriteLine($"Вы ввели корректное число: {a}");
                int month = a / 60;
                int minutes = a % 60;
                Console.WriteLine($"Количество часов: {month}, Количество минут: {minutes}");

            }
            */

            // Задача 8

            /* 
            int min = 0;
            int max = 1000;
            Console.Write($"Введите первое число от {min} до {max}: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < min || a > max)
            {
                Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            }
            else
            {
                Console.WriteLine($"Вы ввели корректное число: {a}");
                min = 1;
                max = 100;
                Console.Write($"Введите второе число от {min} до {max}: ");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b < min || b > max)
                {
                    Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
                }
                else
                {
                    Console.WriteLine($"Вы ввели корректное число: {b}");
                    int apple_to_all = a / b;
                    int apple_ost = a % b;
                    Console.WriteLine($"Каждый ребенок получит {apple_to_all} яблок(а), а {apple_ost} яблок(а) останется(ются)"); ;

                }
            } 
            */
            // Задача 9

            /*
            int min = 10;
            int max = 99;
            Console.Write($"Введите первое число от {min} до {max}: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < min || a > max)
            {
                Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            }
            else
            {
                Console.WriteLine($"Вы ввели корректное число: {a}");
                int ten = a / 10;
                int one = a % 10;
                int summ = ten + one;
                Console.WriteLine($"Десятки: {ten}, Единицы: {one}, Сумма цифр: {summ}");

            }
            */

            // Задача 10

            /*
            int min = -1000;
            int max = 1000;
            Console.Write($"Введите первое число от {min} до {max}: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < min || a > max)
            {
                Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            }
            else
            {
                Console.WriteLine($"Вы ввели корректное число: {a}");
                Console.Write($"Введите второе число от {min} до {max}: ");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b < min || b > max)
                {
                    Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
                }
                else
                {
                    Console.WriteLine($"Вы ввели корректное число: {b}");
                    int c = a;
                    a = b;
                    b = c;
                    Console.WriteLine($"После обмена значениями: a = {a}, b = {b}"); 

                }
            } 
            */
            // Задача 11

            //int min = -1000;
            //int max = 1000;
            //Console.Write($"Введите первое число от {min} до {max}: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a < min || a > max)
            //{
            //    Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //}
            //else
            //{
            //    Console.WriteLine($"Вы ввели корректное число: {a}");
            //    if (a > 0)
            //    {
            //        Console.WriteLine("Число положительное");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Число неположительное");
            //    }

            //}

            // Задача 12

            //int min = -1000;
            //int max = 1000;
            //Console.Write($"Введите первое число от {min} до {max}: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a < min || a > max)
            //{
            //    Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //}
            //else
            //{
            //    Console.WriteLine($"Вы ввели корректное число: {a}");
            //    if (a % 2 == 0)
            //    {
            //        Console.WriteLine("Число четное");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Число нечетное");
            //    }

            //}

            // Задача 13

            //int min = -1000;
            //int max = 1000;
            //Console.Write($"Введите первое число от {min} до {max}: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a < min || a > max)
            //{
            //    Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //}
            //else
            //{
            //    Console.WriteLine($"Вы ввели корректное число: {a}");
            //    Console.Write($"Введите второе число от {min} до {max}: ");
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    if (b < min || b > max)
            //    {
            //        Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Вы ввели корректное число: {b}");
            //        if (a > b)
            //        {
            //            Console.WriteLine($"Число {a} больше числа {b}");
            //        }
            //        else if (a < b)
            //        {
            //            Console.WriteLine($"Число {a} меньше числа {b}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Числа {a} равны");
            //        }

            //    }
            //}


            // Задача 14

            //int min = 0;
            //int max = 100;
            //Console.Write($"Введите первое число от {min} до {max}: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a < min || a > max)
            //{
            //    Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //}
            //else
            //{
            //    Console.WriteLine($"Вы ввели корректное число: {a}");
            //    if (a >= 60)
            //    {
            //        Console.WriteLine("Зачет");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Нужно потренироваться");
            //    }

            //}

            // Задача 15

            //int min = 0;
            //int max = 10000;
            //Console.Write($"Введите первое число от {min} до {max}: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a < min || a > max)
            //{
            //    Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //}
            //else
            //{
            //    Console.WriteLine($"Вы ввели корректное число: {a}");
            //    Console.Write($"Введите второе число от {min} до {max}: ");
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    if (b < min || b > max)
            //    {
            //        Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Вы ввели корректное число: {b}");
            //        if (a > b)
            //        {

            //            Console.WriteLine($"Недостаток {a - b}");
            //        }
            //        else if (a < b)
            //        {
            //            Console.WriteLine($"Остаток {b - a}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Остаток {a - b}");
            //        }

            //    }
            //}


            // Задание 21

            //int min = -1000;
            //int max = 1000;
            //Console.Write($"Введите первое число от {min} до {max}: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a < min || a > max)
            //{
            //    Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //}
            //else
            //{
            //    Console.WriteLine($"Вы ввели корректное число: {a}");
            //    if (a > 0)
            //    {
            //        Console.WriteLine("Положительно");
            //    }
            //    else if (a < 0)
            //    {
            //        Console.WriteLine("Отрицательно");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ноль");
            //    }

            //}

            // Задание 22

            //int min = -1000;
            //int max = 1000;
            //Console.Write($"Введите первое число от {min} до {max}: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a < min || a > max)
            //{
            //    Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //}
            //else
            //{
            //    Console.WriteLine($"Вы ввели корректное число: {a}");
            //    Console.Write($"Введите второе число от {min} до {max}: ");
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    if (b < min || b > max)
            //    {
            //        Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Вы ввели корректное число: {b}");
            //        if (a > b)
            //        {
            //            Console.WriteLine($"Первое больше");
            //        }
            //        else if (a < b)
            //        {
            //            Console.WriteLine($"Второе больше");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Числа равны");
            //        }

            //    }
            //}


            //Задание 23
            //int min = -100;
            //int max = 100;
            //Console.Write($"Введите первое число от {min} до {max}: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a < min || a > max)
            //{
            //    Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //}
            //else
            //{
            //    Console.WriteLine($"Вы ввели корректное число: {a}");
            //    if (a >= 10 && a <= 20)
            //    {
            //        Console.WriteLine("В диапазоне");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Не в диапазоне");
            //    }
            //}

            //Задание 24
            //int min = -100;
            //int max = 100;
            //Console.Write($"Введите первое число от {min} до {max}: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a < min || a > max)
            //{
            //    Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //}
            //else
            //{
            //    Console.WriteLine($"Вы ввели корректное число: {a}");
            //    if (a % 3 == 0 || a % 5 == 0 || a % 3 == 0 && a % 5 == 0)
            //    {
            //        Console.WriteLine("Подходит");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Не подходит");
            //    }
            //}

            // Задание 25
            //int min = 0;
            //int max = 100;
            //Console.Write($"Введите первое число от {min} до {max}: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a < min || a > max)
            //{
            //    Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //}
            //else
            //{
            //    Console.WriteLine($"Вы ввели корректное число: {a}");
            //    if (a < 50)
            //    {
            //        Console.WriteLine("2");
            //    }
            //    else if (a >= 50 && a < 70)
            //    {
            //        Console.WriteLine("3");
            //    }
            //    else if (a >= 70 && a < 90)
            //    {
            //        Console.WriteLine("4");
            //    }
            //    else if (a >= 90 && a <= 100)
            //    {
            //        Console.WriteLine("5");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Значение не подходит");
            //    }
            //}

            // Задание 31
            
            //int min = 0;
            //int max = 20;
            //Console.Write($"Введите первое число от {min} до {max}: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a < min || a > max)
            //{
            //    Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //}
            //else
            //{
            //    Console.WriteLine($"Вы ввели корректное число: {a}");
            //    for (int i = 1; i <= a; i++)
            //    {
            //        Console.Write(i); Console.Write(", ");
            //    }
            //}
            
            // Задание 32

            //int min = 0;
            //int max = 20;
            //Console.Write($"Введите первое число от {min} до {max}: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a < min || a > max)
            //{
            //    Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //}
            //else
            //{
            //    Console.WriteLine($"Вы ввели корректное число: {a}");
            //    for (int i = a; i >= 1; i--)
            //    {
            //        Console.Write(i); Console.Write(", ");

            //    }
            //    Console.WriteLine("Старт!");
            //}

            // Задание 33

            //int min = 0;
            //int max = 10;
            //Console.WriteLine("Введите вашу фразу:");
            //string a = Console.ReadLine();
            //Console.WriteLine("Сколько раз вы хотите ее повторить?");
            //int b = Convert.ToInt32(Console.ReadLine());
            //if (b < min || b > max)
            //{
            //    Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //}
            //else
            //{
            //    Console.WriteLine($"Вы ввели корректное число: {a}");
            //    for (int i = 1; i <= b; i++)
            //    {
            //        Console.WriteLine($"{a}");
            //    }
            //}

            // Задание 34
            
            //int min = 0;
            //int max = 10;
            //Console.Write($"Введите первое число от {min} до {max}: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a < min || a > max)
            //{
            //    Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //}
            //else
            //{
            //    Console.WriteLine($"Вы ввели корректное число: {a}");
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        int proizvod = a * i;
            //        Console.WriteLine($"{a} * {i} = {proizvod} ");
            //    }
            //}


            // Задание 35

            //int min = 1;
            //int max = 1000;
            //Console.Write($"Введите первое число от {min} до {max}: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a < min || a > max)
            //{
            //    Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //}
            //else
            //{
            //    Console.WriteLine($"Вы ввели корректное число: {a}");
            //    int summ = 0;
            //    string steps = "";
            //    for (int i = 1; i <= a; i++)
            //    {
            //        summ += i; 
                    
            //        if ( i == a)
            //        {
            //            steps += i;
            //        }
            //        else
            //        {
            //            steps += $"{i} + ";
            //        }
                    
            //    }

            //    Console.WriteLine($"{steps} = {summ}");
            //}


            // Задание 41
            
            //int min = -100;
            //int max = 100;

            //int summ = 0;

            //Console.WriteLine("Введите целое число(0 для выхода):");
            //int number = Convert.ToInt32(Console.ReadLine());

            //while (number != 0)
            //{
            //    if (number < min || number > max)
            //    {
            //        Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //    }
            //    else
            //    {
            //        summ += number;
            //        Console.WriteLine($"Вы ввели корректное число: {number}");
            //    }
            //    Console.WriteLine("Введите целое число(0 для выхода):");
            //    number = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine($"Сумма введенных чисел: {summ}");
            

            // Задание 42
            //int min = 0;
            //int max = 100;

            //int count = 0;

            //Console.WriteLine("Введите целое число(-1 для выхода):");
            //int number = Convert.ToInt32(Console.ReadLine());

            //while (number != -1)
            //{
            //    if (number < min || number > max)
            //    {
            //        Console.WriteLine($"Ошибка! Число должно быть в диапазоне от {min} до {max}.");
            //    }
            //    else
            //    {
            //        count++;
            //        Console.WriteLine($"Вы ввели корректное число: {number}");
            //    }
            //    Console.WriteLine("Введите целое число(-1 для выхода):");
            //    number = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine($"Колличество значений: {count}");

            // Задание 43
            //Console.Write("Введите целое число от 1 до 5: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //while (number < 1 || number > 5)
            //{

            //    Console.WriteLine("Введите число от 1 до 5");

            //    Console.Write("Введите целое число от 1 до 5: ");
            //    number = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine($"Принято: {number}");

            // Задание 44
            //Console.Write("Введите цель от 1 до 10000 рублей: ");
            //int goal = Convert.ToInt32(Console.ReadLine());

            //int sum = 0;
            //int count = 0;

            //while (sum < goal)
            //{
            //    Console.Write("Введите сумму пополнения от 1 до 1000 рублей: ");
            //    int payment = Convert.ToInt32(Console.ReadLine());

            //    sum = sum + payment;
            //    count = count + 1;
            //}

            //Console.WriteLine($"Накоплено: {sum}. Пополнений: {count}.");

            // Задание 45
            //int secretCode = 2468; 
            //int count = 0;        

            //Console.Write("Введите учебный код: ");
            //int userCode = Convert.ToInt32(Console.ReadLine());
            //count = count + 1; 

            //while (userCode != secretCode && count < 3)
            //{
            //    Console.WriteLine("Неверный код. Попробуйте еще раз.");

            //    Console.Write("Введите учебный код: ");
            //    userCode = Convert.ToInt32(Console.ReadLine());
            //    count = count + 1; 
            //}

            //if (userCode == secretCode)
            //{
            //    Console.WriteLine("Код принят");
            //}
            //else
            //{
            //    Console.WriteLine("Попытки закончились");
            //}
        }
    }
}