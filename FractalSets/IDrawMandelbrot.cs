using System.Drawing;
namespace FractalSets
{
    interface IDrawMandelbrot
    {
        void Draw(int Width, int Height, int Maxiterations, double Xmax, double Xmin, double Ymax, double Ymin, double _dx, double _dy, double ORealX, double RealX, double OImY, double ImY);
    }
}
