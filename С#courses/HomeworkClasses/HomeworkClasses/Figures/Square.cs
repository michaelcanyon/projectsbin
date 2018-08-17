using System;

namespace Figures
{
    class Square : FigureWithSide
    {
        private const int squareSidesQuantity = 4;

        /// <summary>
        /// Конструктор квадрата. Это фигура со стороной. Новыъ полей нет.
        /// </summary>
        /// <param name="name">Название квадрата</param>
        /// <param name="colour">Цвет квадрата</param>
        /// <param name="side">Строна квадрата</param>
        /// <param name="center">Центр квадрата</param>
        public Square(string name, string colour, int side, Point center)
            : base(name, colour, center, side)
        { }

        /// <summary>
        /// Конструктор квадрата по умолчанию
        /// </summary>
        public Square()
                : this("Default square", "White", 76, new Point(3, 15))
        { }

        /// <summary>
        /// Печать информации о квадрате
        /// </summary>
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Side equals " + Side);
        }

        /// <summary>
        /// Площадь квадрата
        /// </summary>
        /// <returns>Площадь квадрата</returns>
        protected override double GetSquare()
        {
            return Math.Pow(Side, 2);
        }

        /// <summary>
        /// Периметр квадрата
        /// </summary>
        /// <returns>Периметр квадрата</returns>
        protected override double GetPerimetr()
        {
            return squareSidesQuantity * Side;
        }
    }
}
