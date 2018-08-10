using System;

namespace HomeworkClasses
{
    class Square : FigureWithSide
    {
        public Square(string name, string colour, int side, Point center)
            :base(name, colour, center, side)
        {
        }
        public Square()
                : this("Default square", "White", 76, new Point(3, 15))
        { }

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
