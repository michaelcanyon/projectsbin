using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClasses
{
    interface IVoulumeFigure
    {
        double height { get; set; }
        double GetVolume();
        double GetVolumeSquare();
    }
}
