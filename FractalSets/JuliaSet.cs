using System;
using System.Drawing;
using FastBitmapLib;

namespace FractalSets
{
    class JuliaSet:AbstractSet
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
        IDrawJulia fractal;
        public void Draw()
        {
            fractal.Draw(Width,Height, RealX,ImY,Maxiterations,ORealX,OImY,Cx,Cy);
        }
        public JuliaSet(int width, int height, int maxiterations, double cx,double cy, IDrawJulia methclass):base(width, height,maxiterations)
        {
            Cy = cy;
            Cx = cx;
            fractal = methclass;
        }
    }
}

