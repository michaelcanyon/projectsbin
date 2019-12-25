using System.Drawing;
using System;
using BenchmarkDotNet.Attributes;

namespace FractalSets
{
    public abstract class AbstractFractal : IFractalBase, IPicture
    {
        /// <summary>
        /// Высота картинки по умолчанию
        /// </summary>
        private const int DEFAULT_HEIGHT = 1920;
        /// <summary>
        /// Щирина картинки по умолчанию
        /// </summary>
        private const int DEFAULT_WIDTH = 1080;
        /// <summary>
        /// Количество итераций, за которое рисуется фрактал по умолчанию
        /// </summary>
        private const int DEFAULT_MAXITERATIONS = 300;
        private int _width;
        private int _height;
        /// <summary>
        /// Ширина картинки
        /// </summary>
        public int Width
        {
            get { return _width; }
            set { _width = value >= 0 ? value : DEFAULT_WIDTH; }
        }
        /// <summary>
        /// Высота картинки
        /// </summary>
        public int Height
        {
            get { return _height; }
            set { _height = value >= 0 ? value : DEFAULT_HEIGHT; }
        }
        /// <summary>
        /// Действительная часть X координаты
        /// </summary>
        public double RealX { get; set; }
        /// <summary>
        /// Мнимая часть Y координаты
        /// </summary>
        public double ImY { get; set; }
        /// <summary>
        /// Действительная часть X координаты на пред.итерации
        /// </summary>
        public double ORealX { get; set; }
        /// <summary>
        /// Мнимая часть Y координаты на пред.итерации
        /// </summary>
        public double OImY { get; set; }
        /// <summary>
        /// Количество итераций, за которое рисуется фрактал
        /// </summary>
        public int MaxIterations { get; set; }
        /// <summary>
        /// Стратегия отрисовки
        /// </summary>
        public IFractalDrawer FractalDrawer { get; set; }
        public virtual Bitmap Draw()
        {
            if (FractalDrawer == null)
                throw new Exception("Не передан фрактал");
            return FractalDrawer.Draw(this);
        }
        protected AbstractFractal(int height=DEFAULT_HEIGHT, int width= DEFAULT_WIDTH, int maxIterations=DEFAULT_MAXITERATIONS)
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
        protected AbstractFractal(IFractalDrawer fractalDrawer)
        {
            FractalDrawer = fractalDrawer;
        }
    }
}
