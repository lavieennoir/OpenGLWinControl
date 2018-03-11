using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenGLWinControl.OpenGL
{
    //
    //  This file imports functions
    //  wich starts with glColor
    //
    public static partial class GL
    {
        #region Functions with value parameters

        [DllImport("opengl32.dll", EntryPoint = "glColor3b")]
        public static extern void Color3(sbyte red, sbyte green, sbyte blue);

        [DllImport("opengl32.dll", EntryPoint = "glColor3d")]
        public static extern void Color3(double red, double green, double blue);

        [DllImport("opengl32.dll", EntryPoint = "glColor3f")]
        public static extern void Color3(float red, float green, float blue);

        [DllImport("opengl32.dll", EntryPoint = "glColor3i")]
        public static extern void Color3(int red, int green, int blue);

        [DllImport("opengl32.dll", EntryPoint = "glColor3s")]
        public static extern void Color3(short red, short green, short blue);

        [DllImport("opengl32.dll", EntryPoint = "glColor3ub")]
        public static extern void Color3(byte red, byte green, byte blue);

        [DllImport("opengl32.dll", EntryPoint = "glColor3ui")]
        public static extern void Color3(uint red, uint green, uint blue);

        [DllImport("opengl32.dll", EntryPoint = "glColor3us")]
        public static extern void Color3(ushort red, ushort green, ushort blue);

        [DllImport("opengl32.dll", EntryPoint = "glColor4b")]
        public static extern void Color4(sbyte red, sbyte green, sbyte blue, sbyte alpha);

        [DllImport("opengl32.dll", EntryPoint = "glColor4d")]
        public static extern void Color4(double red, double green, double blue, double alpha);

        [DllImport("opengl32.dll", EntryPoint = "glColor4f")]
        public static extern void Color4(float red, float green, float blue, float alpha);

        [DllImport("opengl32.dll", EntryPoint = "glColor4i")]
        public static extern void Color4(int red, int green, int blue, int alpha);

        [DllImport("opengl32.dll", EntryPoint = "glColor4s")]
        public static extern void Color4(short red, short green, short blue, short alpha);

        [DllImport("opengl32.dll", EntryPoint = "glColor4ub")]
        public static extern void Color4(byte red, byte green, byte blue, byte alpha);

        [DllImport("opengl32.dll", EntryPoint = "glColor4ui")]
        public static extern void Color4(uint red, uint green, uint blue, uint alpha);

        [DllImport("opengl32.dll", EntryPoint = "glColor4us")]
        public static extern void Color4(ushort red, ushort green, ushort blue, ushort alpha);

        #endregion

        #region Functions with array pointer parameter import

        [DllImport("opengl32.dll", EntryPoint = "glColor3dv")]
        private static extern void Color3dv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glColor3fv")]
        private static extern void Color3fv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glColor3iv")]
        private static extern void Color3iv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glColor3sv")]
        private static extern void Color3sv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glColor3ubv")]
        private static extern void Color3bv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glColor4dv")]
        private static extern void Color4dv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glColor4fv")]
        private static extern void Color4fv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glColor4iv")]
        private static extern void Color4iv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glColor4sv")]
        private static extern void Color4sv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glColor4ubv")]
        private static extern void Color4bv(IntPtr v);

        #endregion

        #region Functions with array pointer parameter wrappers

        public static void Color3(sbyte[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v.Select(x => (byte)(x - sbyte.MinValue)).ToArray(), 0, ptr, v.Length);
                    Color3bv(ptr);
                });


        public static void Color3(double[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Color3dv(ptr);
                });


        public static void Color3(float[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Color3fv(ptr);
                });


        public static void Color3(int[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Color3iv(ptr);
                });


        public static void Color3(short[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Color3sv(ptr);
                });


        static IntPtr color3bv = IntPtr.Zero;

        public static void Color3(byte[] v) 
        {
            int ptrLen = 3;
            if (v == null || v.Length != ptrLen)
                throw new ArgumentException("Array has not enough elements.");
            if (color3bv.Equals(IntPtr.Zero))
                color3bv = Marshal.AllocHGlobal(Marshal.SizeOf(v[0]) * ptrLen);
            try
            {
                Marshal.Copy(v, 0, color3bv, v.Length);
                Color4bv(color3bv);
            }
            catch (Exception e)
            {
                color3bv = IntPtr.Zero;
                throw new ArgumentException("Can`t cast to unmanaged array.", e);
            }
        }
        //InvokeWithArrayPointer(ref v,
        //        (ptr) => {
        //            Marshal.Copy(v, 0, ptr, v.Length);
        //            Color3bv(ptr);
        //        });


        public static void Color3(uint[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v.Select(x => (int)(x + int.MinValue)).ToArray(), 0, ptr, v.Length);
                    Color3iv(ptr);
                });


        public static void Color3(ushort[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v.Select(x => (short)(x + short.MinValue)).ToArray(), 0, ptr, v.Length);
                    Color3sv(ptr);
                });


        public static void Color4(sbyte[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v.Select(x => (byte)(x - sbyte.MinValue)).ToArray(), 0, ptr, v.Length);
                    Color4bv(ptr);
                });


        public static void Color4(double[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Color4dv(ptr);
                });


        public static void Color4(float[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Color4fv(ptr);
                });


        public static void Color4(int[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Color4iv(ptr);
                });


        public static void Color4(short[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Color4sv(ptr);
                });

        
        static IntPtr color4bv = IntPtr.Zero;

        public static void Color4(byte[] v)
        {
            int ptrLen = 4;
            if (v == null || v.Length != ptrLen)
                throw new ArgumentException("Array has not enough elements.");
            if (color4bv.Equals(IntPtr.Zero))
                color4bv = Marshal.AllocHGlobal(Marshal.SizeOf(v[0]) * ptrLen);
            try
            {
                Marshal.Copy(v, 0, color4bv, v.Length);
                Color4bv(color4bv);
            }
            catch (Exception e)
            {
                //Marshal.FreeHGlobal(ptr);
                color4bv = IntPtr.Zero;
                throw new ArgumentException("Can`t cast to unmanaged array.", e);
            }
        }
            //InvokeWithArrayPointer(ref v,
            //    (ptr) => {
            //        Marshal.Copy(v, 0, ptr, v.Length);
            //        Color4bv(ptr);
            //    });


        public static void Color4(uint[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v.Select(x => (int)(x + int.MinValue)).ToArray(), 0, ptr, v.Length);
                    Color4iv(ptr);
                });


        public static void Color4(ushort[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v.Select(x => (short)(x - short.MinValue)).ToArray(), 0, ptr, v.Length);
                    Color4sv(ptr);
                });

        #endregion
    }
}
