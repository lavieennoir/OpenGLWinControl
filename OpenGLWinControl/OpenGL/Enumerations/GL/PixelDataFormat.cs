﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGLWinControl.OpenGL.Enumerations.GL
{
    public enum PixelDataFormat : ushort
    {
        COLOR_INDEX = 0x1900,
        STENCIL_INDEX = 0x1901,
        DEPTH_COMPONENT = 0x1902,
        RED = 0x1903,
        GREEN = 0x1904,
        BLUE = 0x1905,
        ALPHA = 0x1906,
        RGB = 0x1907,
        RGBA = 0x1908,
        LUMINANCE = 0x1909,
        LUMINANCE_ALPHA = 0x190A
    }
}
