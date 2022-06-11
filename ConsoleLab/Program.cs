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
            try
            {
                //.... ArgumentException
            }
            catch(ArgumentException e)
            {
                Console.WriteLine("Argument");
            }
            catch
            {
                Console.WriteLine("Other");
            }
        }

        public static void foo<T>(T num)
        {
            dynamic dnum = num;
            dynamic two = 2;
            try
            {
                Console.WriteLine(two + dnum);
            }
            catch
            {
                Console.WriteLine("No operator + found");
            }
            finally
            {
                Console.WriteLine("Executed!");
            }
        }
    }
}