using System.Drawing;

namespace FractalSets
{
   abstract class AbstractSet: IFractalBase, IPicture
    {
        private const int _defWidth = 400, _defHeight = 300;
        private int _Width;
        private int _height;
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

        public abstract Bitmap Draw();
        public AbstractSet(int height, int width)
        {
            Height = height;
            Width = width;
        }
    }
}
