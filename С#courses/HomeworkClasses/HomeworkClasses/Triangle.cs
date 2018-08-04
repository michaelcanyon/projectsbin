using System;
namespace HomeworkClasses
{
    class Triangle : Figure
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
                    throw new ArgumentException("Error. Side can't be ngative or null");
                }
                    _FSide = value;
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
                    throw new ArgumentException("Error. Side can't be ngative or null");
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
                    throw new ArgumentException("Error. Side can't be ngative or null");
                }
                else
                {
                    _TSide = value;
                }
            }
        }
        #endregion
        //public Triangle()
        //{
        //    Name = "Default Triangle";
        //    Colour = "Red";
        //    FSide = 6;
        //    SSide = 2;
        //    TSide = 3;
        //    Center = new Point(6, 9);
        //}
        public Triangle(string name, string colour, int FirstSide, int SecondSide, int ThirdSide, Point center)
            :base(name, colour, center)
        {
            FSide = FirstSide;
            SSide = SecondSide;
            TSide = ThirdSide;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Sides equal " + FSide + "  " + SSide + "  " + TSide);
        }
        protected override double GetPerimetr()
        {
            return FSide + SSide + TSide;
        }
        protected override double GetSquare()
        {
           double HP = GetPerimetr() / 2;
            return Math.Sqrt(HP * (HP - FSide) * (HP - SSide) * (HP - TSide));
        }
    }
}
