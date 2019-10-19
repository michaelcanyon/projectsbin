using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FractalSets
{
    class MandelbrotSet:AbstractSet
    {
        private double _dx, _dy;
        public double Xmin { get; set; }
        public double Xmax { get; set; }
        public double Ymin { get; set; }
        public double Ymax { get; set; }
        public IDrawMandelbrot fractal;
        public void Draw()
        {
           fractal.Draw(Width, Height, Maxiterations, Xmax, Xmin, Ymax, Ymin, _dx, _dy, ORealX, RealX, OImY,ImY); 
        }
        public MandelbrotSet(int iterations, double xmin, double xmax, double ymin, double ymax, int height, int width, IDrawMandelbrot methclass) : base(height, width, iterations)
        {
            Maxiterations = iterations;
            Xmin = xmin;
            Xmax = xmax;
            Ymin = ymin;
            Ymax = ymax;
            fractal = methclass;
        }
    }
}
