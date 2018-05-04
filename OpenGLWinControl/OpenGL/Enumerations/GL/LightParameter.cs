using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGLWinControl.OpenGL.Enumerations.GL
{
    public enum LightParameter : ushort
    {
        AMBIENT = 0x1200,
        DIFFUSE = 0x1201,
        SPECULAR = 0x1202,
        POSITION = 0x1203,
        SPOT_DIRECTION = 0x1204,
        SPOT_EXPONENT = 0x1205,
        SPOT_CUTOFF = 0x1206,
        CONSTANT_ATTENUATION = 0x1207,
        LINEAR_ATTENUATION = 0x1208,
        QUADRATIC_ATTENUATION = 0x1209
    }
}
