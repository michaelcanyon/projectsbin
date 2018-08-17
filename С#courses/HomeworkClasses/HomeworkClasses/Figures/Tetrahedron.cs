using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Tetrahedron : Triangle, IVoulumeFigure
    {
        private const int tetrahedronConst1 = 12;
        private const int tetrahedronConst2 = 2;

        /// <summary>
        /// Конструктор тетраэдра
        /// </summary>
        /// <param name="name">Название тетраэдра</param>
        /// <param name="colour">Цвет тетраэдра</param>
        /// <param name="side">Сторона тетраэдра</param>
        /// <param name="center">Центр тетраэдра</param>
        public Tetrahedron(string name, string colour, int side, Point center)
            : base(name, colour, side, center)
        {}

        /// <summary>
        /// Вычисление объема тетраэдра
        /// </summary>
        /// <returns>Обхем тетраэдра</returns>
        public double GetVolume()
        {
            return (Math.Pow(Side, 3) / tetrahedronConst1) * Math.Sqrt(tetrahedronConst2);
        }

        /// <summary>
        /// Вычисление площади поверхности тетраэдра
        /// </summary>
        /// <returns>Площадь поверхности тетраэдра</returns>
        public double GetVolumeSquare()
        {
            return Math.Pow(Side,2) * Math.Sqrt(3);
        }

        /// <summary>
        /// Печать информации о тетраэдре
        /// </summary>
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Volume equals " + GetVolume());
            Console.WriteLine("Tetrahedeon square equals " + GetVolumeSquare());
        }
    }
}
