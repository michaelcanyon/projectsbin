using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Cube : Square, IVoulumeFigure
    {
        private const int cubeSidesQuantity = 6;

        /// <summary>
        /// Конструктор куба
        /// </summary>
        /// <param name="name"></param>
        /// <param name="colour"></param>
        /// <param name="side"></param>
        /// <param name="center"></param>
        public Cube(string name, string colour, int side, Point center)
            : base(name, colour, side, center)
        {}
        /// <summary>
        /// Вычисление объема куба
        /// </summary>
        /// <returns>Объем куба</returns>
        public double GetVolume()
        {
            return GetSquare() * Side;
        }

        /// <summary>
        /// Вычисление площади поверхности куба
        /// </summary>
        /// <returns>Площадь поверхности куба</returns>
        public double GetVolumeSquare()
        {
            return GetSquare() * cubeSidesQuantity;
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
