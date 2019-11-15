﻿using System;
using FastBitmapLib;
using System.Drawing;
namespace FractalSets
{
    class FractalDrawMandelbrotFast : IFractalDrawer
    {
        private double _dx, _dy;
        public void Draw(IFractalBase FractalParam)
        {
            var fractal = FractalParam as MandelbrotFractal;
            FastBitmap pic = new FastBitmap(fractal.Width, fractal.Height);
            double tempx;
            _dx = (fractal.Xmax - fractal.Xmin) / fractal.Width;
            _dy = (fractal.Ymax - fractal.Ymin) / fractal.Height;
            fractal.ORealX = fractal.Xmin;
            for (int i = 1; i < fractal.Width; i++)
            {
                fractal.OImY = fractal.Ymin;
                for (int j = 1; j < fractal.Height; j++)
                {
                    fractal.RealX = 0;
                    fractal.ImY = 0;
                    int l;
                    for (l = 0; l < fractal.MaxIterations && ((fractal.RealX * fractal.RealX) + (fractal.ImY * fractal.ImY)) < 4; l++)
                    {
                        tempx = (fractal.RealX * fractal.RealX) - (fractal.ImY * fractal.ImY) + fractal.ORealX;
                        fractal.ImY = 2 * fractal.RealX * fractal.ImY + fractal.OImY;
                        fractal.RealX = tempx;
                    }
                    pic.SetPixel(i, j, Color.FromArgb(255, (l * 9) % 255, 0, (l * 9) % 255));
                    fractal.OImY += _dy;
                }
                fractal.ORealX += _dx;
            }
            try
            {
                pic.Save(fractal.Fname);
            }
            catch
            {
                Console.WriteLine("Invalid filename");
            }
        }
    }
}
