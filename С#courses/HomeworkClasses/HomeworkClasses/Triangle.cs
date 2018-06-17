using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClasses
{
    class Triangle : BasicParametrs
    {
        #region SideCheck
        private int _FSide, _SSide, _TSide;
        public int FSide
        {
            get
            {
                return _FSide;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Error. Side can't be ngative or null");
                }
                else
                {
                    _FSide = value;
                }
            }

        }
        public int SSide
        {
            get
            {
                return _SSide;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Error. Side can't be ngative or null");
                }
                else
                {
                    _SSide = value;
                }
            }
        }
        public int TSide
        {
            get
            {
                return _TSide;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Error. Side can't be ngative or null");
                }
                else
                {
                    _TSide = value;
                }
            }

        }
        #endregion
        public int GetPerimetr()
        {
            return FSide + SSide + TSide;
        }
        public int GetSquare()
        {
            int HP=GetPerimetr()/2;
            return (int)Math.Sqrt(HP * (HP - FSide) * (HP - SSide) * (HP - TSide));
        }
        public void ShowInfo()
        {
            Console.WriteLine("figure:" + Name);
            Console.WriteLine("Colour:" + Colour);
            Console.WriteLine("Sides equal " + FSide+"  "+SSide+"  "+TSide);
            Center.ShowInfo();
            Console.WriteLine("S=" + GetSquare() + ";   P=" + GetPerimetr());
        }
        public Triangle()
        {
            Name = "Default Triangle";
            Colour = "Red";
            FSide = 6;
            SSide = 2;
            TSide = 3;
            Center = new Point(6, 9);


        }
        public Triangle(string name, string colour, int FirstSide, int SecondSide, int ThirdSide, Point center)
        {
            Name = name;
            Colour = colour;
            FSide = FirstSide;
            SSide = SecondSide;
            TSide = ThirdSide;
            Center = center;

        }
    }
}
