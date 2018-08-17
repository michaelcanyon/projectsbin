using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{  
    class Orb : Circle, IVoulumeFigure
    {
        private const int orbSquareParametr = 4;

        /// <summary>
        /// Конструктор шара
        /// </summary>
        /// <param name="name">Название шара</param>
        /// <param name="colour">Цвет шара</param>
        /// <param name="radius">Радиус шара</param>
        /// <param name="center">Центр шара</param>
        public Orb(string name, string colour, int radius, Point center)
            : base(name, colour, radius, center)
        { }

        /// <summary>
        /// Вычисление объема шара
        /// </summary>
        /// <returns>Объем шара</returns>
        public double GetVolume()
        {
            return (4 / 3) * Math.PI * Math.Pow(Radius,3);
        }

        /// <summary>
        /// Вычисления площади поверхности шара
        /// </summary>
        /// <returns>Площадь поверхности шара</returns>
        public double GetVolumeSquare()
        {
            return orbSquareParametr * Math.PI * Math.Pow(Radius,2);
        }

        /// <summary>
        /// Печать информации о шаре
        /// </summary>
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Volume equals " + GetVolume());
            Console.WriteLine("Orb square equals " + GetVolumeSquare());
        }
    }
}
