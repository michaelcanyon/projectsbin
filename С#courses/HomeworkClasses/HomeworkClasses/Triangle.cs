using System;
namespace HomeworkClasses
{
    class Triangle : FigureWithSide
    {
        /// <summary>
        /// Конструктор треугольника. Это фигура со стороной. Новых полей нет.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="colour"></param>
        /// <param name="side"></param>
        /// <param name="center"></param>
        public Triangle(string name, string colour, int side, Point center)
            : base(name, colour, center, side)
        {
        }

        /// <summary>
        /// Конструктор треугольника со значениями по умолчанию
        /// </summary>
        public Triangle()
            : this("Default Triangle", "Red", 6, new Point(6, 9))
        { }

        /// <summary>
        /// Печать информации о треугольнике
        /// </summary>
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Side equals " + Side);
        }

        /// <summary>
        /// Пеример треугольника
        /// </summary>
        /// <returns></returns>
        protected override double GetPerimetr()
        {
            return 3 * Side;
        }

        /// <summary>
        /// Площадь треугольника
        /// </summary>
        /// <returns></returns>
        protected override double GetSquare()
        {
            double HP = GetPerimetr() / 2;
            return Math.Sqrt(3) / 4 * (Side * Side);
        }
    }
}
