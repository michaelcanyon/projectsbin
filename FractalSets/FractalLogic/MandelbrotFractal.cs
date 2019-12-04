using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FractalSets
{
    class MandelbrotFractal : AbstractFractal, IMandelbrotFractal
    {
        private double _dx, _dy;
        public double Xmin { get; set; }
        public double Xmax { get; set; }
        public double Ymin { get; set; }
        public double Ymax { get; set; }
        public MandelbrotFractal(int iterations, double xmin, double xmax, double ymin, double ymax, int height, int width)
            : base(height, width, iterations)
        {
            Xmin = xmin;
            Xmax = xmax;
            Ymin = ymin;
            Ymax = ymax;
        }
        public MandelbrotFractal(int iterations, double xmin, double xmax, double ymin, double ymax, int height, int width, IFractalDrawer fractalDrawer)
            : base(height, width, iterations, fractalDrawer)
        {
            Xmin = xmin;
            Xmax = xmax;
            Ymin = ymin;
            Ymax = ymax;
        }
    }
}
