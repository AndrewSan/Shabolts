﻿using System.Collections.Generic;
using System;

namespace Test
{
    class Program
    {
        delegate int UseOperation(int a, int b);
        delegate void GetGreeting();

        static void Main(string[] args)
        {
            GetGreeting del = GoodMorning;
            UseOperation delegat = Add;
            if (DateTime.Now.Hour < 12)
                del = GoodMorning;
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
                del = GoodDay;
            else if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour < 22)
                del = GoodEvening;
            else if (DateTime.Now.Hour >= 22 || DateTime.Now.Hour < 11)
                del = GoodEvening;
            del();


            Console.WriteLine("  Введите числа для расчёта");
            Console.Write("  a - ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("  b - ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("  Какую операцию провернуть (+,-,*,/) - ");
            string operacia = Convert.ToString(Console.ReadLine());
            if (operacia=="+")
                delegat = Add;
            else if (operacia == "-")
                delegat = Subtract;
            else if (operacia == "*")
                delegat = Multiply;
            else if (operacia == "/")
                delegat = IntegerDevide;
            delegat(a,b);
        }

        static void GoodMorning()
        {
            Console.WriteLine("Доброе утро!");
        }
        static void GoodDay()
        {
            Console.WriteLine("Добрый день!");
        }
        static void GoodEvening()
        {
            Console.WriteLine("Добрый вечер!");
        }
        static void GoodNight()
        {
            Console.WriteLine("Доброй ночи!");
        }

        static int Add(int x, int y)
        {
            Console.Write("  Результат додавання - " + (x + y));
            return x + y;
        }
        static int Subtract(int x, int y)
        {
            Console.Write("  Результат вычитания - " + (x - y));
            return x - y;
        }
        static int Multiply(int x, int y)
        {
            Console.Write("  Результат умножения - " + (x * y));
            return x * y;
        }
        static int IntegerDevide(int x, int y)
        {
            Console.Write("  Результат деления - " + (x / y));
            return x / y;
        }
    }
}