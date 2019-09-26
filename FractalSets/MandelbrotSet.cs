using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FractalSets
{
    class MandelbrotSet : IMandelbrotSet, IPicture
    {
        private const int _defWidth = 400, _defHeight = 300;
        private int _Width,_height;
        private double _dx, _dy;
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
        public double Xmin { get; set; }
        public double Xmax { get; set; }
        public double Ymin { get; set; }
        public double Ymax { get; set; }
        public Bitmap Draw()
        {
            Bitmap picture = new Bitmap(Width, Height);
            double tempx;
            _dx = (Xmax - Xmin) / Width;
            _dy = (Ymax - Ymin) / Height;
            ORealX = Xmin;
            for (int i = 1; i < Width; i++)
            {
                OImY = Ymin;
                for (int j = 1; j < Height; j++)
                {
                    RealX = 0;
                    ImY = 0;
                    int l;
                    for (l = 0; l < Maxiterations && Math.Sqrt((RealX * RealX) + (ImY * ImY)) < 2 ;l++)
                    {
                        tempx = (RealX * RealX) - (ImY * ImY) + ORealX;
                        ImY = 2 * RealX * ImY + OImY;
                        RealX = tempx;
                    }
                    picture.SetPixel(i, j, Color.FromArgb(255, (l * 9) % 255, 0, (l * 9) % 255));
                    OImY += _dy;
                }
                ORealX += _dx;
            }
            return picture;
        }
        public MandelbrotSet(int iterations, Bitmap bitmap, double xmin, double xmax,double ymin, double ymax)
        {
            Maxiterations = iterations;
            Width = bitmap.Width;
            Height = bitmap.Height;
            Xmin = xmin;
            Xmax = xmax;
            Ymin = ymin;
            Ymax = ymax;         
        }
    }
}
