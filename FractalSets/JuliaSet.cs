using System;
using System.Drawing;

namespace FractalSets
{
    class JuliaSet : AbstractSet, IJuliaFractal, IPicture
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
        public override Bitmap Draw()
        {
            Bitmap picture = new Bitmap(Width, Height);
            for (int x = 0; x < Width - 1; x++)
            {
                for (int y = 0; y < Height - 1; y++)
                {
                    RealX = 1.5 * (x - Width / 2) / (Width * 0.5);
                    ImY = (y - Height / 2) / (Height * 0.5);
                    int i;
                    for (i = 0; i < Maxiterations; i++)
                    {
                        ORealX = RealX;
                        OImY = ImY;
                        RealX = ORealX * ORealX - OImY * OImY + Cx;
                        ImY = 2 * ORealX * OImY + Cy;
                        if ((RealX * RealX + ImY * ImY) > 4)
                        { break; }
                    }
                    picture.SetPixel(x, y, Color.FromArgb(255, (i * 9) % 255, 0, (i * 9) % 255));
                }
            }
            return picture;
        }
        public JuliaSet(double cy, double cx, int iterations,int height, int width):base(height, width)
        {
            Cy = cy;
            Cx = cx;
            Maxiterations = iterations;
        }
    }
}

