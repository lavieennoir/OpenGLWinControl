using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGLWinControl.OpenGL.Enumerations
{
    public enum HintTarget : ushort
    {
        PERSPECTIVE_CORRECTION_HINT = 0x0C50,
        POINT_SMOOTH_HINT = 0x0C51,
        LINE_SMOOTH_HINT = 0x0C52,
        POLYGON_SMOOTH_HINT = 0x0C53,
        FOG_HINT = 0x0C54
    }
}
