using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FractalSets
{
    public interface IFractalBase
    {
        /// <summary>
        /// Действительная часть функции на текущей итерации
        /// </summary>
        double RealX { get; set; }
        /// <summary>
        /// Мнимая часть функции на текущей итерации
        /// </summary>
        double ImY { get; set; }
        /// <summary>
        /// Действительная часть функции на предыдущей итерации
        /// </summary>
        double ORealX { get; set; }
        /// <summary>
        /// Мнимая часть функции на предыдущей итерации
        /// </summary>
        double OImY { get; set; }
        int MaxIterations { get; set; }
    }
}
