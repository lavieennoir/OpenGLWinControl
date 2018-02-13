using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGLWinControl.OpenGL.Enumerations.GL
{
    public enum ClientAttributeMask : uint
    {
        CLIENT_PIXEL_STORE_BIT = 0x00000001,
        CLIENT_VERTEX_ARRAY_BIT = 0x00000002,
        CLIENT_ALL_ATTRIB_BITS = 0xffffffff
    }
}
