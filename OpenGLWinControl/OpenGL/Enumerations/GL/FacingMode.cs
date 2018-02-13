using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGLWinControl.OpenGL.Enumerations.GL
{
    public enum FacingMode : ushort
    {
        NONE = 0,
        FRONT = 0x0404,
        BACK = 0x0405,
        FRONT_AND_BACK = 0x0408,
    }
}
