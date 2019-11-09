using System;
using System.Drawing;

namespace FractalSets
{
    class FractalDrawerJuliaSimple: IFractalDrawer<JuliaSet>
    {
        public void Draw(JuliaSet fractal)
        {
            //var fractal = fractal as JuliaSet;
            //if (fractal == null)
            //   throw new Exception("F");
            var pic = new Bitmap(fractal.Width, fractal.Height);
            for (int x = 0; x < fractal.Width - 1; x++)
            {
                for (int y = 0; y < fractal.Height - 1; y++)
                {
                    fractal.RealX = 1.5 * (x - fractal.Width / 2) / (fractal.Width * 0.5);
                    fractal.ImY = (y - fractal.Height / 2) / (fractal.Height * 0.5);
                    int i;
                    for (i = 0; i < fractal.MaxIterations; i++)
                    {
                        fractal.ORealX = fractal.RealX;
                        fractal.OImY = fractal.ImY;
                        fractal.RealX = fractal.ORealX * fractal.ORealX - fractal.OImY * fractal.OImY + fractal.Cx;
                        fractal.ImY = 2 * fractal.ORealX * fractal.OImY + fractal.Cy;
                        if ((fractal.RealX * fractal.RealX + fractal.ImY * fractal.ImY) > 4)
                        { break; }
                    }
                    // Enumerable range
                    pic.SetPixel(x, y, Color.FromArgb(255, (i * 9) % 255, 0, (i * 9) % 255));
                }
            }
            //Temporary solution
            pic.Save("C://Users//Michael//Desktop//Fract08.jpg");
        }
    }

    class FractalDrawerJuliaFastSequent : IFractalDrawer<JuliaSet>
    {
        public void Draw(JuliaSet fractal)
        {
            Bitmap pic = new Bitmap(fractal.Width, fractal.Height);
            for (int x = 0; x < fractal.Width - 1; x++)
            {
                for (int y = 0; y < fractal.Height - 1; y++)
                {
                    fractal.RealX = 1.5 * (x - fractal.Width / 2) / (fractal.Width * 0.5);
                    fractal.ImY = (y - fractal.Height / 2) / (fractal.Height * 0.5);
                    int i;
                    for (i = 0; i < fractal.MaxIterations; i++)
                    {
                        fractal.ORealX = fractal.RealX;
                        fractal.OImY = fractal.ImY;
                        fractal.RealX = fractal.ORealX * fractal.ORealX - fractal.OImY * fractal.OImY + fractal.Cx;
                        fractal.ImY = 2 * fractal.ORealX * fractal.OImY + fractal.Cy;
                        if ((fractal.RealX * fractal.RealX + fractal.ImY * fractal.ImY) > 4)
                        { break; }
                    }
                    // Enumerable range
                    pic.SetPixel(x, y, Color.FromArgb(255, (i * 9) % 255, 0, (i * 9) % 255));
                }
            }
            //Temporary solution
            pic.Save("C://Users//Michael//Desktop//Fract08.jpg");
        }
    }
}
