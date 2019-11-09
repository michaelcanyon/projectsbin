using System;
using System.Collections.Generic;
using System.Drawing;

namespace FractalSets
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = "C://Users//Michael//Desktop//Fract08.jpg";
            Bitmap picture;
            JuliaSet newFract = new JuliaSet(600, 800, 300, -0.254362425435387, -0.764323274433643325, new FractalDrawerJuliaSimple());
            //MandelbrotSet newFract1 = new MandelbrotSet(300, -2.1, 1, -1.3, 1.3, 600, 800, new SimpleDrawMandelbrot());
            newFract.Draw();
            //newFract.Draw();
            //bitmap.Save(filepath);
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
