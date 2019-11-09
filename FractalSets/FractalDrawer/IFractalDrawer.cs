using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalSets
{
    public interface IFractalDrawer<T> where T : AbstractSet
    {
       void Draw(T fractal);
    }
}
