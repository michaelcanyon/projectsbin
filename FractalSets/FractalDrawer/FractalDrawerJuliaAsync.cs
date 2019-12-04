using System.Linq;
using System.Drawing;
using System;

namespace FractalSets
{
    class FractalDrawerJuliaAsync : IFractalDrawer
    {
        struct point
        {
            public int x;
            public int y;
            public Color color;
        }
        public Bitmap Draw(IFractalBase FractalParam)
        {
            var fractal = FractalParam as JuliaFractal;
            Bitmap picture = new Bitmap(fractal.Width, fractal.Height);
            var points = Enumerable.Range(0, fractal.Width * fractal.Height).AsParallel().Select(Calculations);
            foreach (point i in points)
            {
                picture.SetPixel(i.x, i.y, i.color);
            }
            return picture;
            point Calculations(int pixel)
            {
                double RealX = fractal.RealX;
                double ImY = fractal.ImY;
                double ORealX = fractal.ORealX;
                double OImY = fractal.OImY;

                point tmp = new point();
                tmp.y = pixel / fractal.Width;
                tmp.x = pixel % fractal.Width;
                RealX = 1.5 * (tmp.x - fractal.Width / 2) / (fractal.Width * 0.5);
                ImY = (tmp.y - fractal.Height / 2) / (fractal.Height * 0.5);
                int i;
                for (i = 0; i < fractal.MaxIterations; i++)
                {
                    ORealX = RealX;
                    OImY = ImY;
                    RealX = ORealX * ORealX - OImY * OImY + fractal.Cx;
                    ImY = 2 * ORealX * OImY + fractal.Cy;
                    if ((RealX * RealX + ImY * ImY) > 4)
                    { break; }
                }
                tmp.color = Color.FromArgb(255, (i * 9) % 255, 0, (i * 9) % 255);
                return tmp;
            }
        }
    }
}
