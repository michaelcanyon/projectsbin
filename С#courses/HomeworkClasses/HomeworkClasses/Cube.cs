using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClasses
{
    class Cube : Square, IVoulumeFigure
    {
        private double _height;

        /// <summary>
        /// Конструктор куба
        /// </summary>
        /// <param name="name"></param>
        /// <param name="colour"></param>
        /// <param name="side"></param>
        /// <param name="center"></param>
        public Cube(string name, string colour, int side, Point center)
            : base(name, colour, side, center)
        {
            height = side;
        }

        /// <summary>
        /// Высота куба
        /// </summary>
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

        /// <summary>
        /// Вычисление объема куба
        /// </summary>
        /// <returns></returns>
        public double GetVolume()
        {
            return GetSquare() * height;
        }

        /// <summary>
        /// Вычисление плозади поверхности куба
        /// </summary>
        /// <returns></returns>
        public double GetVolumeSquare()
        {
            return GetSquare() * 6;
        }

        /// <summary>
        /// Печать информации о кубе
        /// </summary>
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Volume equals " + GetVolume());
            Console.WriteLine("Cube square equals " + GetVolumeSquare());
        }
    }
}
