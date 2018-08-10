using System;
namespace HomeworkClasses
{
    class Circle : Figure
    {
        private const string DefaultName = "Default Circle";

        private int _radius;
        // TODO: спроси у Жени про дефолтное заполнение полей
        //public Circle(string name, string colour, int Radius, Point center):
        //    base(name, colour, center)
        //{
        //    Name = "Default Circle";
        //    Colour = "Black like your ex's blood";
        //    radius = 666;
        //    Center = new Point(6, 9);
        //}
        public Circle(string name, string colour, int Radius, Point center)
            :base(name, colour, center)
        {
            this.Radius = Radius;
        }

        public Circle()
            :this(DefaultName, "Black like your ex's blood",666, new Point(6, 9))
        {
        
        }

        /// <summary>
        /// Радиус с большой буквы. Публичное поле.
        /// </summary>
        public int Radius
        {
            get { return _radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Incorrect radius meaning. It can't be negative or null.");
                }
                _radius = value;
            }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Radius equals " + Radius);
        }

        protected override double GetPerimetr()
        {
            return 2 * Radius * Math.PI;
        }

        protected override double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
