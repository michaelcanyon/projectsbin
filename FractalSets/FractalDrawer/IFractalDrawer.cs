﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalSets
{
    public interface IFractalDrawer
    {
        void Draw(IFractalBase fractalParam);
    }
}
