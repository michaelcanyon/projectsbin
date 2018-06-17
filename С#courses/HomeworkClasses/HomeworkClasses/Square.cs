using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClasses
{
    class Square:BasicParametrs
    {
        private int _side;
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
        private int GetSquare()
        {
            return Side * Side;
        }
        private int GetPerimetr()
        {
            return 4 * Side;
        }
        public void ShowInfo()
        {
            Console.WriteLine("figure:" + Name);
            Console.WriteLine("Colour:" + Colour);
            Console.WriteLine("Side equals " + Side);
            Center.ShowInfo();
            Console.WriteLine("S=" + GetSquare() + ";   P=" + GetPerimetr());
        }
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
            Side=side;
            Center = center;

        }

    }
}
