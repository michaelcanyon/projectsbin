using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClasses
{
    class Cube:Square,  IVoulumeFigure
    {
        private double _height;
        public Cube(string name, string colour, int side, Point center)
            :base(name, colour, side, center)
        {
            height = side;
        }
        public double height
        {
            get { return _height; }
            set
            {
                if (value <= 0)
                    throw new Exception("height can't be negative");
                _height = value;
            }
        }

        public double GetVolume()
        {
            return GetSquare() * height;
        }
        public double GetVolumeSquare()
        {
            return GetSquare()*6;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Volume equals " + GetVolume());
            Console.WriteLine("Cube square equals " + GetVolumeSquare());
        }
    }
}
