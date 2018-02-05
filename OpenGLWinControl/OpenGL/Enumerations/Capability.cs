using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGLWinControl.OpenGL.Enumerations
{
    public enum Capability : ushort
    {
        ALPHA_TEST = 0x0BC0,
        AUTO_NORMAL = 0x0D80,
        BLEND = 0x0BE2,

        GL_CLIP_PLANE0 = 0x3000,
        GL_CLIP_PLANE1 = 0x3001,
        GL_CLIP_PLANE2 = 0x3002,
        GL_CLIP_PLANE3 = 0x3003,
        GL_CLIP_PLANE4 = 0x3004,
        GL_CLIP_PLANE5 = 0x3005,

        COLOR_LOGIC_OP = 0x0BF2,
        COLOR_MATERIAL = 0x0B57,
        CULL_FACE = 0x0B44,
        DEPTH_TEST = 0x0B71,
        DITHER = 0x0BD0,
        FOG = 0x0B60,
        INDEX_LOGIC_OP = 0x0BF1,

        LIGHT0 = 0x4000,
        LIGHT1 = 0x4001,
        LIGHT2 = 0x4002,
        LIGHT3 = 0x4003,
        LIGHT4 = 0x4004,
        LIGHT5 = 0x4005,
        LIGHT6 = 0x4006,
        LIGHT7 = 0x4007,
        LIGHTING = 0x0B50,

        LINE_SMOOTH = 0x0B20,
        LINE_STIPPLE = 0x0B24,

        MAP1_COLOR_4 = 0x0D90,
        MAP1_INDEX = 0x0D91,
        MAP1_NORMAL = 0x0D92,
        MAP1_TEXTURE_COORD_1 = 0x0D93,
        MAP1_TEXTURE_COORD_2 = 0x0D94,
        MAP1_TEXTURE_COORD_3 = 0x0D95,
        MAP1_TEXTURE_COORD_4 = 0x0D96,
        MAP1_VERTEX_3 = 0x0D97,
        MAP1_VERTEX_4 = 0x0D98,
        MAP2_COLOR_4 = 0x0DB0,
        MAP2_INDEX = 0x0DB1,
        MAP2_NORMAL = 0x0DB2,
        MAP2_TEXTURE_COORD_1 = 0x0DB3,
        MAP2_TEXTURE_COORD_2 = 0x0DB4,
        MAP2_TEXTURE_COORD_3 = 0x0DB5,
        MAP2_TEXTURE_COORD_4 = 0x0DB6,
        MAP2_VERTEX_3 = 0x0DB7,
        MAP2_VERTEX_4 = 0x0DB8,

        NORMALIZE = 0x0BA1,
        POINT_SMOOTH = 0x0B10,
        POLYGON_OFFSET_POINT = 0x2A01,
        POLYGON_OFFSET_LINE = 0x2A02,
        POLYGON_OFFSET_FILL = 0x8037,
        POLYGON_SMOOTH = 0x0B41,
        POLYGON_STIPPLE = 0x0B42,
        SCISSOR_TEST = 0x0C11,
        STENCIL_TEST = 0x0B90,

        TEXTURE_1D = 0x0DE0,
        TEXTURE_2D = 0x0DE1,
        TEXTURE_GEN_S = 0x0C60,
        TEXTURE_GEN_T = 0x0C61,
        TEXTURE_GEN_R = 0x0C62,
        TEXTURE_GEN_Q = 0x0C63,
    }
}
