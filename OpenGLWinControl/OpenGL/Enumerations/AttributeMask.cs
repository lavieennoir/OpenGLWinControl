using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGLWinControl.OpenGL.Enumerations
{
    [Flags]
    public enum AttributeMask : uint
    {
        DEPTH_BUFFER_BIT = 0x00000100,
        ACCUM_BUFFER_BIT = 0x00000200,
        STENCIL_BUFFER_BIT = 0x00000400,
        COLOR_BUFFER_BIT = 0x00004000,
    }
}
