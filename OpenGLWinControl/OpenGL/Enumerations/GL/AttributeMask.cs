﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGLWinControl.OpenGL.Enumerations.GL
{
    [Flags]
    public enum AttributeMask : uint
    {
        CURRENT_BIT = 0x00000001,
        POINT_BIT = 0x00000002,
        LINE_BIT = 0x00000004,
        POLYGON_BIT = 0x00000008,
        POLYGON_STIPPLE_BIT = 0x00000010,
        PIXEL_MODE_BIT = 0x00000020,
        LIGHTING_BIT = 0x00000040,
        FOG_BIT = 0x00000080,
        DEPTH_BUFFER_BIT = 0x00000100,
        ACCUM_BUFFER_BIT = 0x00000200,
        STENCIL_BUFFER_BIT = 0x00000400,
        VIEWPORT_BIT = 0x00000800,
        TRANSFORM_BIT = 0x00001000,
        ENABLE_BIT = 0x00002000,
        COLOR_BUFFER_BIT = 0x00004000,
        HINT_BIT = 0x00008000,
        EVAL_BIT = 0x00010000,
        LIST_BIT = 0x00020000,
        TEXTURE_BIT = 0x00040000,
        SCISSOR_BIT = 0x00080000,
        ALL_ATTRIB_BITS = 0x000fffff
    }
}
