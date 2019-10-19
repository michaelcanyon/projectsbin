using System;
using System.Drawing;
using FastBitmapLib;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
namespace FractalSets
{
    class SimpleDrawJulia : IDrawJulia
    {
        public void Draw(int Width, int Height, double RealX, double ImY, int Maxiterations, double ORealX, double OImY, double Cx, double Cy)
        {
            Bitmap pic = new Bitmap(Width, Height);
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
                    // Enumerable range
                    pic.SetPixel(x, y, Color.FromArgb(255, (i * 9) % 255, 0, (i * 9) % 255));
                }
            }
            //Temporary solution
            pic.Save("C://Users//Michael//Desktop//Fract08.jpg");
        }
    }
    class SimpleDrawMandelbrot : IDrawMandelbrot
    {
        public void Draw(int Width, int Height, int Maxiterations, double Xmax, double Xmin, double Ymax, double Ymin, double _dx, double _dy, double ORealX, double RealX, double OImY, double ImY)
        {
            Bitmap pic = new Bitmap(Width, Height);
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
                    for (l = 0; l < Maxiterations && ((RealX * RealX) + (ImY * ImY)) < 4; l++)
                    {
                        tempx = (RealX * RealX) - (ImY * ImY) + ORealX;
                        ImY = 2 * RealX * ImY + OImY;
                        RealX = tempx;
                    }
                    pic.SetPixel(i, j, Color.FromArgb(255, (l * 9) % 255, 0, (l * 9) % 255));
                    OImY += _dy;
                }
                ORealX += _dx;
            }
            pic.Save("C://Users//Michael//Desktop//Fract06.jpg");
        }
    }
    class FastJuliaDraw : IDrawJulia
    {
        public void Draw(int Width, int Height, double RealX, double ImY, int Maxiterations, double ORealX, double OImY, double Cx, double Cy)
        {
            FastBitmap picture = new FastBitmap(Width, Height);
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
                    //Enumerable range
                    picture.SetPixel(x, y, Color.FromArgb(255, (i * 9) % 255, 0, (i * 9) % 255));
                }
            }
            //Temporary solution
            picture.Save("C://Users//Michael//Desktop//Fract06.jpg");
        }

    }
    class FastMandelbrotDraw : IDrawMandelbrot
    {
        public void Draw(int Width, int Height, int Maxiterations, double Xmax, double Xmin, double Ymax, double Ymin, double _dx, double _dy, double ORealX, double RealX, double OImY, double ImY)
        {
            FastBitmap pic = new FastBitmap(Width, Height);
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
                    for (l = 0; l < Maxiterations && ((RealX * RealX) + (ImY * ImY)) < 4; l++)
                    {
                        tempx = (RealX * RealX) - (ImY * ImY) + ORealX;
                        ImY = 2 * RealX * ImY + OImY;
                        RealX = tempx;
                    }
                    pic.SetPixel(i, j, Color.FromArgb(255, (l * 9) % 255, 0, (l * 9) % 255));
                    OImY += _dy;
                }
                ORealX += _dx;
            }
            pic.Save("C://Users//Michael//Desktop//Fract06.jpg");
        }
    }

    class JuliaSimpleDrawAsync : IDrawJulia
    {
        struct point
        {
            public int x;
            public int y;
            public Color color;
        }
        public void Draw(int Width, int Height, double RealX, double ImY, int Maxiterations, double ORealX, double OImY, double Cx, double Cy)
        {
            point[] calc = new point[Width * Height];
            Bitmap picture = new Bitmap(Width, Height);
            ParallelLoopResult res = Parallel.For(0, Width * Height, Calculations);
               // Parallel.ForEach<point>(calc, Setpic);
                foreach (point i in calc)
                {
                    picture.SetPixel(i.x, i.y, i.color);
                }
            picture.Save("C://Users//Michael//Desktop//Fract09.jpg");
            void Calculations(int pixel)
            {
                calc[pixel].y = pixel/Width;
                calc[pixel].x = pixel%Width;
                RealX = 1.5 * (calc[pixel].x - Width / 2) / (Width * 0.5);
                ImY = (calc[pixel].y - Height / 2) / (Height * 0.5);
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
                calc[pixel].color = Color.FromArgb(255, (i * 9) % 255, 0, (i * 9) % 255);
            }
        }

    }
    class FastDrawAsync : IDrawJulia
    {
        public void Draw(int Width, int Height, double RealX, double ImY, int Maxiterations, double ORealX, double OImY, double Cx, double Cy)
        { }
    }
}
