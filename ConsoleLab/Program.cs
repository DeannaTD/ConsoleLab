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
            int i = 5;
            double d = 7.5;
            char c = 'a';
            string s = "hello";
            Fraction f = new Fraction(1, 2);

            foo(i);
            foo(d);
            foo(c);
            foo(s);
            foo(f);

            //Teacher, Student, Manager, Admin, Trial, Lead
            //List<Teacher>, List<Student>....
        }

        //DRY - Don't Repeat Yourself
        public static void foo<T>(T num)
        {
            dynamic dnum = num;
            dynamic two = 2;
            Console.WriteLine(two + dnum);
        }
    }
}