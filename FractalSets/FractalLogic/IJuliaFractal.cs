using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalSets
{
    public interface IJuliaFractal : IFractalBase
    {
        /// <summary>
        /// Действительная часть параметра С
        /// </summary>
        double Cx { get; set; }
        /// <summary>
        /// Мнимая часть параметра С
        /// </summary>
        double Cy { get; set; }
    }
}
