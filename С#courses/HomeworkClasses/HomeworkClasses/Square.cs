using System;
namespace HomeworkClasses
{
    class Square : Figure
    {
        private int _side;
        //public Square()
        //{
        //    Name = "Default Square";
        //    Colour = "Blue";
        //    Side = 626;
        //    Center = new Point(6, 9);
        //}
        public Square(string name, string colour, int side, Point center)
            :base(name, colour, center)
        {
            Side = side;
        }

        /// <summary>
        /// Сторону фигуры поместить в класс "фигура"
        /// </summary>
        public int Side
        {
            get
            {
                return _side;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Side can't be negative or null");
                    return;
                }
                else
                {
                    _side = value;
                }
            }
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Side equals " + Side);
        }
        protected override double GetSquare()
        {
            return Math.Pow(Side, 2);
        }
        protected override double GetPerimetr()
        {
            return 4 * Side;
        }
    }
}
