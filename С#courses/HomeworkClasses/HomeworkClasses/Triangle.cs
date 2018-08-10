using System;
namespace HomeworkClasses
{
    class Triangle : FigureWithSide
    {
        public Triangle(string name, string colour, int side, Point center)
            : base(name, colour, center, side)
        {
        }
        public Triangle()
            : this("Default Triangle", "Red", 6, new Point(6, 9))
        { }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Side equals " + Side);
        }
        protected override double GetPerimetr()
        {
            return 3*Side;
        }
        protected override double GetSquare()
        {
           double HP = GetPerimetr() / 2;
            return Math.Sqrt(3)/4*(Side*Side);
        }
    }
}
