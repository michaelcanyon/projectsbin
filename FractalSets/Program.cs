using System;
using System.Collections.Generic;
using System.Drawing;

namespace FractalSets
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = "C://Users//Michael//Desktop//Fract04.jpg";
            var bitmap = new Bitmap(800, 600);
            // JuliaSet newFract = new JuliaSet(-0.5274433643325, -0.5362425435387, 300, bitmap);
            MandelbrotSet newFract = new MandelbrotSet(300, bitmap, -2.1, 1, -1.3, 1.3);
            bitmap = newFract.Draw();
            bitmap.Save(filepath);
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
