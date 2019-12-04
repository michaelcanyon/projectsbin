using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FractalSets.FractalDrawer
{
    class FractalDrawerJuliaSimpleAsync
    {
            struct point
            {
                public int x;
                public int y;
                public Color color;
            }
            public void Draw(int Width, int Height, double RealX, double ImY, int Maxiterations, double ORealX, double OImY, double Cx, double Cy)
            { //поля не бывают публичными _а
              //Все публичные члены класса используют UpperCamelCase для именования
              //Константы и поля для чтения пишутся THIS_CONSTANT_VARIABLE
                point[] calc = new point[Width * Height];
                Bitmap picture = new Bitmap(Width, Height);
                //Вариант записи 1
                //ParallelLoopResult res = Parallel.For(0, Width * Height, Calculations);
                //Вариант записи 2
                var points = Enumerable.Range(0, Width * Height).AsParallel().Select(Calculations);
                foreach (point i in calc)
                {
                    picture.SetPixel(i.x, i.y, i.color);
                }
                picture.Save("C://Users//Michael//Desktop//Fract09.jpg");
                point Calculations(int pixel)
                {
                    point tmp = new point();
                    tmp.y = pixel / Width;
                    tmp.x = pixel % Width;
                    RealX = 1.5 * (tmp.x - Width / 2) / (Width * 0.5);
                    ImY = (tmp.y - Height / 2) / (Height * 0.5);
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
                    tmp.color = Color.FromArgb(255, (i * 9) % 255, 0, (i * 9) % 255);
                    return tmp;
                }
            }
    }
}
