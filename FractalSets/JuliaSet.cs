using System;
using System.Drawing;
using FastBitmapLib;

namespace FractalSets
{
    class JuliaSet: AbstractSet
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
        public JuliaSet(int width, int height, int maxiterations, double cx,double cy,IFractalDrawer<AbstractSet> fractal):base(width, height,maxiterations, fractal)
        {
            Cy = cy;
            Cx = cx;
        }
    }
}

