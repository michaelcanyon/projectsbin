using System;
using System.Drawing;

namespace FractalSets
{
    class JuliaSet : IJuliaFractal, IPicture
    {
        private const int _defWidth = 400, _defHeight = 300;
        private int _Width;
        private int _height;
        private double _cx, _cy;
        public int Width
        {
            get { return _Width; }
            set { _Width = value >= 0 ? value : _defWidth; }
        }
        public int Height
        {
            get { return _height; }
            set { _height = value >= 0 ? value : _defHeight; }
        }
        public double RealX { get; set; }
        public double ImY { get; set; }
        public double ORealX { get; set; }
        public double OImY { get; set; }
        public int Maxiterations { get; set; }
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
        public Bitmap Draw()
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
        public JuliaSet(double cy, double cx, int iterations, Bitmap bitmap)
        {
            Width = bitmap.Width;
            Height = bitmap.Height;
            Cy = cy;
            Cx = cx;
            Maxiterations = iterations;
        }
    }
}

