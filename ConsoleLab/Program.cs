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
            //JS function == object
            //C# function != object

            int? a = 5;
            a = 5;
            string s = null;
            Console.WriteLine(s ?? "null");
            
            SayHello hello = SayHelloWorld;
            hello -= SayHelloWorld;


            Print<int, double> p1 = new Print<int, double>(5);
            Print<string, string> p2 = new Print<string, string>("hello");
            Print<Fraction, int> p3 = new Print<Fraction, int>(new Fraction(1, 3));

            p1.PrintValue();
            p2.PrintValue();
            p3.PrintValue();
            //List<Fraction> list;

            // nullable non-nullable
            //users = GetAllOnlineUsers();
            //users.SendMessage("Go to sleep!");


            //class List<T>
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