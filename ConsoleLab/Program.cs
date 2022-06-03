using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleLab
{
    class Program
    {
        public static string mSec(int num, string name) => num > 0 ? num == 1 ? num + " " + name + " " : num + " " + name + "s " : "";

        public static string formatDuration(int total_seconds)
        {
            if (total_seconds == 0) return "now";

            TimeSpan time = TimeSpan.FromSeconds(total_seconds);

            int[] periods = { (int)time.TotalDays / 365, time.Days % 365, time.Hours, time.Minutes, time.Seconds };
            string[] names = { "year", "day", "hour", "minute", "second" };
            string result = "";

            for (int i = 0; i < periods.Length; i++)
                result += mSec(periods[i], names[i]);

            result = (new Regex(@"\b(\w+)(\s)(\d+)\b")).Replace(result, "$1,$2$3");
            result = (new Regex(@", (\d+) (\w+) $")).Replace(result, " and $1 $2");
            result = (new Regex(@"\s$")).Replace(result, "");

            return result;
        }

        static void Main(string[] args)
        {
            Regex regex = new Regex(@"<[a-z]+.*?>");

            string str = "<p class='there'>Привет</p>\n<a href='hello.html'>ссылка</a>\n<form></form>";
            
                var matches = regex.Matches(str);

                for (int i = 0; i < matches.Count; i++)
                {
                    Console.WriteLine(matches[i].Value);
                }
        }

        public static bool ValidatePin(string pin)
        {
            return true;
        }

        //public static Bitmap CropImage(Image source, int x, int y, int width, int height)
        //{
        //    Rectangle crop = new Rectangle(x, y, width, height);

        //    var bmp = new Bitmap(crop.Width, crop.Height);
        //    using (var gr = Graphics.FromImage(bmp))
        //    {
        //        gr.DrawImage(source, new Rectangle(0, 0, bmp.Width, bmp.Height), crop, GraphicsUnit.Pixel);
        //    }
        //    return bmp;
        //}
    }
}