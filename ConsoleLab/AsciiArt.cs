using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ConsoleLab
{
    internal class AsciiArt
    {
        private static string DensityMap = "$@B%8&WM#*oahkbdpqwmZO0QLCJUYXzcvunxrjft/\\|()1{}[]?-_+~<>i!lI;:,\"^`'. ";

        public Bitmap SourceMap { get; set; }
        public char[,] AsciiMap { get; private set; }

        public AsciiArt(string path)
        {
            if (path is null || path.Length == 0) throw new ArgumentException();
            SourceMap = new Bitmap(path);
            ConvertToAscii();
        }

        private bool ConvertToAscii()
        {
            int width = SourceMap.Width;
            int height = SourceMap.Height;

            AsciiMap = ConvertGrayScale();
            for(int i = 0; i<width; i++)
            {
                for(int j = 0; j<height; j++)
                {
                    Console.Write(AsciiMap[i,j]);
                }
                Console.WriteLine();
            }
            return true;
        }

        private char[,] ConvertGrayScale()
        {
            int width = SourceMap.Width;
            int height = SourceMap.Height;

            char [,] result = new char[width,height];
            int value = 0;
            for (int i = 0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    value = Convert.ToInt32(GetGrayValue(SourceMap.GetPixel(i, j)) * 69 / 255);
                    result[i, j] = DensityMap[value];
                }
            }
            return result;
        }

        private double GetGrayValue(Color color) => (color.R + color.G + color.B) / 3;
    }
}
