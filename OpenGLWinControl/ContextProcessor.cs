using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OpenGLWinControl.OpenGL.Enumerations;

namespace OpenGLWinControl
{
    /// <summary>
    ///     Containts methods to make Windows Forms and OpenGL work together
    /// </summary>
    static class ContextProcessor
    {
        [DllImport("gdi32.dll", EntryPoint = "SwapBuffers", CallingConvention = CallingConvention.Winapi)]
        public static extern bool SwapBuffers(IntPtr hdc);


        [DllImport("user32.dll", EntryPoint = "GetDC")]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("gdi32.dll", EntryPoint = "ChoosePixelFormat")]
        public static extern int ChoosePixelFormat(IntPtr hdc, [In] ref PIXELFORMATDESCRIPTOR ppfd);

        [DllImport("gdi32.dll", EntryPoint = "SetPixelFormat")]
        public static extern bool SetPixelFormat(IntPtr hdc, int iPixelFormat, ref PIXELFORMATDESCRIPTOR ppfd);

        [DllImport("opengl32.dll", EntryPoint = "wglGetCurrentContext", CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr wglGetCurrentContext();

        [DllImport("opengl32.dll", EntryPoint = "wglMakeCurrent", CallingConvention = CallingConvention.Winapi)]
        public static extern bool wglMakeCurrent(IntPtr hdc, IntPtr hglrc);

        [DllImport("opengl32.dll", EntryPoint = "wglCreateContext", CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr wglCreateContext(IntPtr hdc);

        /// <summary>
        ///     Use to set pixel format for control context
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct PIXELFORMATDESCRIPTOR
        {
            ushort nSize;
            ushort nVersion;
            PFD_FLAGS dwFlags;
            PFD_PIXEL_TYPE iPixelType;
            byte cColorBits;
            byte cRedBits;
            byte cRedShift;
            byte cGreenBits;
            byte cGreenShift;
            byte cBlueBits;
            byte cBlueShift;
            byte cAlphaBits;
            byte cAlphaShift;
            byte cAccumBits;
            byte cAccumRedBits;
            byte cAccumGreenBits;
            byte cAccumBlueBits;
            byte cAccumAlphaBits;
            byte cDepthBits;
            byte cStencilBits;
            byte cAuxBuffers;
            PFD_LAYER_TYPES iLayerType;
            byte bReserved;
            uint dwLayerMask;
            uint dwVisibleMask;
            uint dwDamageMask;

            /// <summary>
            /// Initialize PIXELFORMATDESCRIPTOR for OpenGL compatibility
            /// </summary>
            public void Init()
            {
                nSize = (ushort)Marshal.SizeOf(typeof(PIXELFORMATDESCRIPTOR)); // size of this pfd
                nVersion = 1; // version number
                dwFlags = PFD_FLAGS.PFD_DRAW_TO_WINDOW | PFD_FLAGS.PFD_SUPPORT_OPENGL
                    | PFD_FLAGS.PFD_DOUBLEBUFFER | PFD_FLAGS.PFD_SUPPORT_COMPOSITION; // supporting flags
                iPixelType = PFD_PIXEL_TYPE.PFD_TYPE_RGBA; // RGBA type
                cColorBits = 24; // 24-bit color depth
                cRedBits = cRedShift = cGreenBits = cGreenShift = cBlueBits = cBlueShift = 0;
                cAlphaBits = cAlphaShift = 0;
                cAccumBits = cAccumRedBits = cAccumGreenBits = cAccumBlueBits = cAccumAlphaBits = 0;
                cDepthBits = 32; // 16-bit z-buffer
                cStencilBits = cAuxBuffers = 0;
                iLayerType = PFD_LAYER_TYPES.PFD_MAIN_PLANE; // main layer
                bReserved = 0;
                dwLayerMask = dwVisibleMask = dwDamageMask = 0;
            }
        }
    }
}
