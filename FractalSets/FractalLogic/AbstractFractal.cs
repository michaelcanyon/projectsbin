using System.Drawing;
using System;

namespace FractalSets
{
    public abstract class AbstractFractal : IFractalBase, IPicture
    {
        private const int DEF_WIDTH = 400, DEF_HEIGHT = 300;
        private int _width;
        private int _height;
        public int Width
        {
            get { return _width; }
            set { _width = value >= 0 ? value : DEF_WIDTH; }
        }
        public int Height
        {
            get { return _height; }
            set { _height = value >= 0 ? value : DEF_HEIGHT; }
        }
        public double RealX { get; set; }
        public double ImY { get; set; }
        public double ORealX { get; set; }
        public double OImY { get; set; }
        public int MaxIterations { get; set; }
        public IFractalDrawer FractalDrawer { get; set; }
        public string Fname { get; set; }
        public virtual void Draw()
        {
            if (FractalDrawer == null)
                throw new Exception("Не передан фрактал");
            FractalDrawer.Draw(this);
        }
        protected AbstractFractal(int height, int width, int maxIterations)
        {
            Height = height;
            Width = width;
            MaxIterations = maxIterations;
        }
        protected AbstractFractal(int height, int width, int maxIterations, IFractalDrawer fractalDrawer)
            : this(height, width, maxIterations)
        {
            FractalDrawer = fractalDrawer;
        }
        protected AbstractFractal(int height, int width, int maxIterations, IFractalDrawer fractalDrawer, string fname)
            : this(height, width, maxIterations, fractalDrawer)
        {
            Fname = fname;
        }
    }
}
