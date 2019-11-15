using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalSets
{
    interface IMandelbrotFractal : IFractalBase
    {
        double Xmin { get; set; }
        double Xmax { get; set; }
        double Ymin { get; set; }
        double Ymax { get; set; }
    }
}
