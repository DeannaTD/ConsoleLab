using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> vs = new List<int>();

            vs.Sort();

            string s = null;
            Console.WriteLine(s ?? "null");
            
            SayHello hello = SayHelloWorld;
            hello -= SayHelloWorld;

            Action hello2 = SayHelloWorld;
            Predicate<int> p = isOdd;
            Func<int, bool> test = isOdd;

            Class<double> f = new Class<double>(4);
            Type type = f.foo().GetType();
            Console.WriteLine(type);

            /*
             * Action Func Predicate Task
             * 
             поля:
                value - число
             методы:
                конструктор
                метод, который умножает число на 2 и возвращает его
             */
        }

        delegate void SayHello();

        delegate bool NumberProperty(int value);

        static bool IsEven(int a)
        {
            return a % 2 == 0;
        }

        static bool isOdd(int a) => a % 2 != 0;
        static void SayHelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        static void PrintImHere()
        {
            Console.WriteLine("I'm here!");
        }

    }
}