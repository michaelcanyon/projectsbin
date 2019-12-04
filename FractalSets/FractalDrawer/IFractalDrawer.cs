using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FractalSets
{
    public interface IFractalDrawer
    {

        /// <summary>
        /// Отрисовывает фрактал
        /// </summary>
        /// <param name="fractalParam">реализация фрактала</param>
        /// <returns>Заполненная картинка</returns>
        Bitmap Draw(IFractalBase fractalParam);
    }
}
