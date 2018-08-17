using System;
namespace Figures
{
    class Triangle : FigureWithSide
    {
        private const int triangleSidesQuantity = 3;

        /// <summary>
        /// Конструктор треугольника. Это фигура со стороной. Новых полей нет.
        /// </summary>
        /// <param name="name">Название треугольника</param>
        /// <param name="colour">Цвет треугольника</param>
        /// <param name="side">Сторона треугольника</param>
        /// <param name="center">Центр треугольника</param>
        public Triangle(string name, string colour, int side, Point center)
            : base(name, colour, center, side)
        {}

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
        /// <returns>Периметр треугольника</returns>
        protected override double GetPerimetr()
        {
            return triangleSidesQuantity * Side;
        }

        /// <summary>
        /// Площадь треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        protected override double GetSquare()
        {
            double HP = GetPerimetr() / 2;
            return Math.Sqrt(3) / 4 * Math.Pow(Side,2);
        }
    }
}
