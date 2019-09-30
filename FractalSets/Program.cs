using System;
using System.Collections.Generic;
using System.Drawing;

namespace FractalSets
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = "C://Users//Michael//Desktop//Fract06.jpg";
            var bitmap = new Bitmap(800, 600);
            JuliaSet newFract = new JuliaSet(-0.33274433643325, -0.754362425435387, 300, bitmap.Height, bitmap.Width);
            //MandelbrotSet newFract1 = new MandelbrotSet(300, -2.1, 1, -1.3, 1.3,bitmap.Height, bitmap.Width);
            bitmap = newFract.Draw();
            bitmap.Save(filepath);
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
