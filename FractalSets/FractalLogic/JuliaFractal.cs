using System;
using System.Drawing;
using FastBitmapLib;

namespace FractalSets
{
    class JuliaFractal : AbstractFractal, IJuliaFractal
    {

        private double _cx, _cy;
        public double Cx
        {
            get { return _cx; }
            set
            {
                if (value < -1 || value > 1)
                    throw new Exception("Неверное значение параметра С!");
                else
                    _cx = value;
            }
        }
        public double Cy
        {
            get { return _cy; }
            set
            {
                if (value < -1 || value > 1)
                    throw new Exception("Неверное значение параметра С!");
                else
                    _cy = value;
            }
        }
        public JuliaFractal(int width, int height, int maxiterations, double cx, double cy, IFractalDrawer fractalDrawer)
            : base(width, height, maxiterations, fractalDrawer)
        {
            Cy = cy;
            Cx = cx;
        }
        public JuliaFractal(int width, int height, int maxiterations, double cx, double cy)
            : base(width, height, maxiterations)
        {
            Cy = cy;
            Cx = cx;
        }
    }
}

