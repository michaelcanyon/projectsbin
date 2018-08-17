using System;
namespace Figures
{
    class Circle : Figure
    {
        private const string DefaultName = "Default Circle";
        private const int squareParametr= 2;

        private int _radius;

        /// <summary>
        /// Конструктор круга
        /// </summary>
        /// <param name="name">Название круга</param>
        /// <param name="colour">Цвет круга</param>
        /// <param name="radius">Радиус круга</param>
        /// <param name="center">Центральная точка круга</param>
        public Circle(string name, string colour, int radius, Point center)
            : base(name, colour, center)
        {
            Radius = radius;
        }

        /// <summary>
        /// Поля круга, заполненные по умолчанию
        /// </summary>
        public Circle()
            : this(DefaultName, "Black like your ex's blood", 666, new Point(6, 9))
        { }

        /// <summary>
        /// Радиус круга
        /// </summary>
        public int Radius
        {
            get { return _radius; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Incorrect radius meaning. It can't be negative or null.");
                _radius = value;
            }
        }

        /// <summary>
        /// Печать информации о круге
        /// </summary>
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Radius equals " + Radius);
        }

        /// <summary>
        /// Периметр круга
        /// </summary>
        /// <returns>Периметр круга</returns>
        protected override double GetPerimetr()
        {
            return squareParametr * Radius * Math.PI;
        }

        /// <summary>
        /// Площадь круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        protected override double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
