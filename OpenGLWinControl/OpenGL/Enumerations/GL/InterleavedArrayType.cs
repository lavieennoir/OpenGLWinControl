using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGLWinControl.OpenGL.Enumerations.GL
{
    public enum InterleavedArrayType : ushort
    {
        V2F = 0x2A20,
        V3F = 0x2A21,
        C4UB_V2F = 0x2A22,
        C4UB_V3F = 0x2A23,
        C3F_V3F = 0x2A24,
        N3F_V3F = 0x2A25,
        C4F_N3F_V3F = 0x2A26,
        T2F_V3F = 0x2A27,
        T4F_V4F = 0x2A28,
        T2F_C4UB_V3F = 0x2A29,
        T2F_C3F_V3F = 0x2A2A,
        T2F_N3F_V3F = 0x2A2B,
        T2F_C4F_N3F_V3F = 0x2A2C,
        T4F_C4F_N3F_V4F = 0x2A2D
    }
}
