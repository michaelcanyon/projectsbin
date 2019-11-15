﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace FractalSets
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = "C://Users//Michael//Desktop//Fract10.jpg";
            Bitmap picture;
            //JuliaFractal fractal = new JuliaFractal(600, 800, 300, -0.254362425435387, -0.764323274433643325, new FractalDrawerJuliaAsync());
            //IFractalDrawer<JuliaFractal> fractalDrawer = new FractalDrawerJuliaSimple<JuliaFractal>();
            //fractal.FractalDrawer = fractalDrawer;
            MandelbrotFractal fractal = new MandelbrotFractal(300, -2.1, 1, -1.3, 1.3, 600, 800, new FractalDrawerMandelbrotFastAsync(), filepath);
            fractal.Draw();
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
