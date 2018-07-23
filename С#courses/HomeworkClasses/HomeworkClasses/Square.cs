using System;
namespace HomeworkClasses
{
    class Square : Figure
    {
        private int _side;
        public Square()
        {
            Name = "Default Square";
            Colour = "Blue";
            Side = 626;
            Center = new Point(6, 9);
        }
        public Square(string name, string colour, int side, Point center)
        {
            Name = name;
            Colour = colour;
            Side = side;
            Center = center;
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
                else
                {
                    _side = value;
                }
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("figure:" + Name);
            Console.WriteLine("Colour:" + Colour);
            Console.WriteLine("Side equals " + Side);
            Center.ShowInfo();
            Console.WriteLine("S=" + GetSquare() + ";   P=" + GetPerimetr());
        }
        private int GetSquare()
        {
            return Side * Side;
        }
        private int GetPerimetr()
        {
            return 4 * Side;
        }

    }
}
