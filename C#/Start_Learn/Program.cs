using System;
namespace Ahuet;

class Program
{
    static void Main()
    {
        /* This is a simple C# program that prints "Hello, World!" to the console.
        Console.WriteLine("Hello, World!");
        Console.Write("Hello \n\n");
        Console.Write("123"); */

        int a = 100; 
        Console.WriteLine("Переменная - " + a);
        a = -35;
        Console.WriteLine(a);

        uint b = 1; // Только положительные , 32 бита, от 0 до 4 294 967 295
        Console.WriteLine(b);

        byte c = 255; // Только положительные, от 0 до 255 В разы меньше оперативы жрет чем int , 8 битов
        Console.WriteLine(c);

        short d = 32767; // от -32768 до 32767, Второй по величине тип данных, занимает 16 битов 
        Console.WriteLine(d);

        long e = 9223372036854775807; // от -9223372036854775808 до 9223372036854775807, занимает 64 бита; 
        Console.WriteLine(e);

        float f = 4.529942039085983209f; // от -3.402823e38 до 3.402823e38, занимает 32 бита
        Console.WriteLine(f);

        double g = 4.529942039085983209d; // от -1.79769313486232e308 до 1.79769313486232e308, занимает 64 бита
        Console.WriteLine(g);

        string word = "Hello World!"; // Строка, может содержать любые символы, занимает 16 бит на символ
        Console.WriteLine(word);

        char h = 'A'; // Символ, занимает 16 бит
        Console.WriteLine(h);

        bool tf = true; // Логический тип данных, может быть только true или false, занимает 1 бит
        Console.WriteLine(tf);

        // Получние данных
        Console.ReadKey();


    }
}