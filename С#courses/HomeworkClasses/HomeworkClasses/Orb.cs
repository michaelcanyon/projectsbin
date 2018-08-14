using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClasses
{
    class Orb : Circle, IVoulumeFigure
    {
        /// <summary>
        ///Высота фигуры. Поле не используется.
        /// </summary>
        public double height { get; set; }

        /// <summary>
        /// Конструктор шара
        /// </summary>
        /// <param name="name"></param>
        /// <param name="colour"></param>
        /// <param name="Radius"></param>
        /// <param name="center"></param>
        public Orb(string name, string colour, int Radius, Point center)
            : base(name, colour, Radius, center)
        { }

        /// <summary>
        /// Вычисление объема шара
        /// </summary>
        /// <returns></returns>
        public double GetVolume()
        {
            return (4 / 3) * Math.PI * (Radius * Radius * Radius);
        }

        /// <summary>
        /// Вычисления площади поверхности шара
        /// </summary>
        /// <returns></returns>
        public double GetVolumeSquare()
        {
            return 4 * Math.PI * (Radius * Radius);
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
