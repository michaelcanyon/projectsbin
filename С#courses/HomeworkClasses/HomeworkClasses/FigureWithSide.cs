using System;
namespace HomeworkClasses
{
    abstract class FigureWithSide:Figure
    {
        private int _side;

        protected FigureWithSide(string name, string colour, Point center, int side)
            : base(name, colour, center)
        {
            Side = side;
        }

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
                    _side = value;
            }
        }
    }
}
