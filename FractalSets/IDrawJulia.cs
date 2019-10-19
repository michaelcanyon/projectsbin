using System.Drawing;

namespace FractalSets
{
    interface IDrawJulia
    {
        void Draw(int Width, int Height, double RealX, double ImY, int Maxiterations, double ORealX, double OImY, double Cx, double Cy);
    }
}
