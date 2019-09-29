using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FractalSets
{
    class MandelbrotSet : AbstractSet, IMandelbrotSet, IPicture
    {
        private double _dx, _dy;
        public double Xmin { get; set; }
        public double Xmax { get; set; }
        public double Ymin { get; set; }
        public double Ymax { get; set; }
        public override Bitmap Draw()
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
