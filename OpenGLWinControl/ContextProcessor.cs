﻿using System;
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
        #region Imports 

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

        #endregion

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

        #region Win32 flags

        [Flags]
        public enum PFD_FLAGS : uint
        {
            PFD_DOUBLEBUFFER = 0x00000001,
            PFD_STEREO = 0x00000002,
            PFD_DRAW_TO_WINDOW = 0x00000004,
            PFD_DRAW_TO_BITMAP = 0x00000008,
            PFD_SUPPORT_GDI = 0x00000010,
            PFD_SUPPORT_OPENGL = 0x00000020,
            PFD_GENERIC_FORMAT = 0x00000040,
            PFD_NEED_PALETTE = 0x00000080,
            PFD_NEED_SYSTEM_PALETTE = 0x00000100,
            PFD_SWAP_EXCHANGE = 0x00000200,
            PFD_SWAP_COPY = 0x00000400,
            PFD_SWAP_LAYER_BUFFERS = 0x00000800,
            PFD_GENERIC_ACCELERATED = 0x00001000,
            PFD_SUPPORT_DIRECTDRAW = 0x00002000,
            PFD_DIRECT3D_ACCELERATED = 0x00004000,
            PFD_SUPPORT_COMPOSITION = 0x00008000,
            PFD_DEPTH_DONTCARE = 0x20000000,
            PFD_DOUBLEBUFFER_DONTCARE = 0x40000000,
            PFD_STEREO_DONTCARE = 0x80000000
        }

        public enum PFD_LAYER_TYPES : byte
        {
            PFD_MAIN_PLANE = 0,
            PFD_OVERLAY_PLANE = 1,
            PFD_UNDERLAY_PLANE = 255
        }

        public enum PFD_PIXEL_TYPE : byte
        {
            PFD_TYPE_RGBA = 0,
            PFD_TYPE_COLORINDEX = 1
        }
        #endregion
    }
}
