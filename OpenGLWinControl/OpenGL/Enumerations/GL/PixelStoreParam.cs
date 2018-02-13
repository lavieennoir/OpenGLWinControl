using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGLWinControl.OpenGL.Enumerations.GL
{
    public enum PixelStoreParam : ushort
    {
        PACK_SWAP_BYTES = 0x0D00,
        UNPACK_SWAP_BYTES = 0x0CF0,
        PACK_LSB_FIRST = 0x0D01,
        UNPACK_LSB_FIRST = 0x0CF1,
        PACK_ROW_LENGTH = 0x0D02,
        UNPACK_ROW_LENGTH = 0x0CF2,
        PACK_SKIP_PIXELS = 0x0D04,
        UNPACK_SKIP_PIXELS = 0x0CF4,
        PACK_SKIP_ROWS = 0x0D03,
        UNPACK_SKIP_ROWS = 0x0CF3,
        PACK_ALIGNMENT = 0x0D05,
        UNPACK_ALIGNMENT = 0x0CF5
    }
}
