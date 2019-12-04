using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FractalSets
{
    class FractalDrawMandelbrotSimpleAsync : IFractalDrawer
    {
        private struct Point
        {
            public int x;
            public int y;
            public Color color;
        }
        public Bitmap Draw(IFractalBase FractalParam)
        {
            double _dx, _dy;
            var fractal = FractalParam as MandelbrotFractal;
            Bitmap pic = new Bitmap(fractal.Width, fractal.Height);
            _dx = (fractal.Xmax - fractal.Xmin) / fractal.Width;
            _dy = (fractal.Ymax - fractal.Ymin) / fractal.Height;
            var points = Enumerable.Range(0, fractal.Width * fractal.Height).AsParallel().Select(Calculations);
            foreach (Point i in points)
            {
                pic.SetPixel(i.x, i.y, i.color);
            }
            return pic;
            Point Calculations(int pixel)
            {
                double tempx;
                double ORealX = 0;
                double RealX = 0;
                double OImY = 0;
                double ImY = 0;
                var p = new Point();
                p.y = pixel / fractal.Width;
                p.x = pixel % fractal.Width;
                OImY = p.y * _dy + fractal.Ymin;
                ORealX = p.x * _dx + fractal.Xmin;
                int l;
                for (l = 0; l < fractal.MaxIterations && ((RealX * RealX) + (ImY * ImY)) < 4; l++)
                {
                    tempx = (RealX * RealX) - (ImY * ImY) + ORealX;
                    ImY = 2 * RealX * ImY + OImY;
                    RealX = tempx;
                }
                p.color = Color.FromArgb(255, (l * 9) % 255, 0, (l * 9) % 255);
                return p;
            }
        }
    }
}
