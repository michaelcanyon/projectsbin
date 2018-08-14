using System;

namespace HomeworkClasses
{
    class Square : FigureWithSide
    {
        /// <summary>
        /// Конструктор квадрата. Это фигура со стороной. Новыъ полей нет.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="colour"></param>
        /// <param name="side"></param>
        /// <param name="center"></param>
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
        /// <returns></returns>
        protected override double GetSquare()
        {
            return Math.Pow(Side, 2);
        }

        /// <summary>
        /// Периметр квадрата
        /// </summary>
        /// <returns></returns>
        protected override double GetPerimetr()
        {
            return 4 * Side;
        }
    }
}
