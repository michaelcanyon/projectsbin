using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClasses
{
    class Tetrahedron:Triangle, IVoulumeFigure
    {
        private double _height;
        public Tetrahedron(string name, string colour, int side, Point center)
            :base(name, colour, side, center)
        {
            height =0.66666667*Side;
        }

        public double height
        {
            get { return _height; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("height can't be negative"); }
                _height = value;
            }
        }

        public double GetVolume()
        {
            return (Math.Pow(Side,3)/12)*Math.Sqrt(2);
        }
        public double GetVolumeSquare()
        {
            return (Side*Side)*Math.Sqrt(3);
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Height equals " + height);
            Console.WriteLine("Volume equals " + GetVolume());
            Console.WriteLine("Tetrahedeon square equals " + GetVolumeSquare());
        }
    }
}
