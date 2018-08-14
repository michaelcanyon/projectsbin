using System;
namespace HomeworkClasses
{
    class Circle : Figure
    {
        private const string DefaultName = "Default Circle";

        private int _radius;

        /// <summary>
        /// Конструктор круга
        /// </summary>
        /// <param name="name"></param>
        /// <param name="colour"></param>
        /// <param name="Radius"></param>
        /// <param name="center"></param>
        public Circle(string name, string colour, int Radius, Point center)
            : base(name, colour, center)
        {
            this.Radius = Radius;
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
        /// <returns></returns>
        protected override double GetPerimetr()
        {
            return 2 * Radius * Math.PI;
        }

        /// <summary>
        /// Площадь круга
        /// </summary>
        /// <returns></returns>
        protected override double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
