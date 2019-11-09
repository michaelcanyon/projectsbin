using System.Drawing;
using System;

namespace FractalSets
{
    public abstract class AbstractSet : IFractalBase, IPicture
    {
        //? добавить методы DrawFastBitmap, DrawAsync, DrawAsyncFBitmap  и замерить время
        // или попытаться передавать обобщающим параметром класс fastbitmap и тогда вместо 4 методов, будут 2: Draw & DrawAsync
        // ? Распараллеливание процесса отрисовки. Поместить каждый цикл в задачу. Получатся вложенные задачи. Не уверен, что это повлияет на время выполнения.
        // возможно только разгрузит главный поток. Ещё вопрос в том, будут ли вычисления выполняться корректно, если цикл, котрый выше по иерархии, завершит
        // работу раньше вложенного. Вопрос в том, может ли это повлиять на результаты вычислений
        // ? Есть предположение, что можно поместить также отрисовку в параллельный метод. Так главный поток не будет оставаться замороженным во время отрисовки
        // ? Отработать каждый из методов отрисовки. Записать замеренное время работы метода в словарь с характеризующим метод ключом.
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
        public IFractalDrawer<AbstractSet> FractalDrawer { get; set; }
        public virtual void Draw()
        {
            if (FractalDrawer == null)
                throw new Exception("Не передан фрактал");
            FractalDrawer.Draw(FractalDrawer);
        }
        protected AbstractSet(int height, int width, int maxIterations)
        {
            Height = height;
            Width = width;
            MaxIterations = maxIterations;
        }
        protected AbstractSet(int height, int width, int maxIterations, IFractalDrawer<AbstractSet> fractalDrawer)
            : this(height, width, maxIterations)
        {
            FractalDrawer = fractalDrawer;
        }

    }
}
