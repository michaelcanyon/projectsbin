using System;
using System.Linq;
using System.Drawing;
using FastBitmapLib;

namespace FractalSets
{
    class FractalDrawerMandelbrotFastAsync : IFractalDrawer
    {
        struct point
        {
            public int x;
            public int y;
            public Color color;
        }
        public Bitmap Draw(IFractalBase FractalParam)
        {
            double _dx, _dy;
            var fractal = FractalParam as MandelbrotFractal;
            FastBitmap pic = new FastBitmap(fractal.Width, fractal.Height);
            _dx = (fractal.Xmax - fractal.Xmin) / fractal.Width;
            _dy = (fractal.Ymax - fractal.Ymin) / fractal.Height;
            var points = Enumerable.Range(0, fractal.Width * fractal.Height).AsParallel().Select(Calculations);
            foreach (point i in points)
            {
                pic.SetPixel(i.x, i.y, i.color);
            }
            return pic;
            point Calculations(int pixel)
            {
                double tempx;
                double ORealX = 0;
                double RealX = 0;
                double OImY = 0;
                double ImY = 0;
                point tmp = new point();
                tmp.y = pixel / fractal.Width;
                tmp.x = pixel % fractal.Width;
                OImY = tmp.y * _dy + fractal.Ymin;
                ORealX = tmp.x * _dx + fractal.Xmin;
                int l;
                for (l = 0; l < fractal.MaxIterations && ((RealX * RealX) + (ImY * ImY)) < 4; l++)
                {
                    tempx = (RealX * RealX) - (ImY * ImY) + ORealX;
                    ImY = 2 * RealX * ImY + OImY;
                    RealX = tempx;
                }
                tmp.color = Color.FromArgb(255, (l * 9) % 255, 0, (l * 9) % 255);
                return tmp;
            }
        }
    }
}
