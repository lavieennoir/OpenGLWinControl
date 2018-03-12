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
    public partial class GL
    {
        #region Functions with value parameters

        [DllImport("opengl32.dll", EntryPoint = "glColor3b")]
        static extern void color3(sbyte red, sbyte green, sbyte blue);

        public void Color3(sbyte red, sbyte green, sbyte blue) =>
            color3(red, green, blue);

        [DllImport("opengl32.dll", EntryPoint = "glColor3d")]
        static extern void color3(double red, double green, double blue);

        public void Color3(double red, double green, double blue) =>
            color3(red, green, blue);

        [DllImport("opengl32.dll", EntryPoint = "glColor3f")]
        static extern void color3(float red, float green, float blue);

        public void Color3(float red, float green, float blue) =>
            color3(red, green, blue);

        [DllImport("opengl32.dll", EntryPoint = "glColor3i")]
        static extern void color3(int red, int green, int blue);

        public void Color3(int red, int green, int blue) =>
            color3(red, green, blue);

        [DllImport("opengl32.dll", EntryPoint = "glColor3s")]
        static extern void color3(short red, short green, short blue);

        public void Color3(short red, short green, short blue) =>
            color3(red, green, blue);

        [DllImport("opengl32.dll", EntryPoint = "glColor3ub")]
        static extern void color3(byte red, byte green, byte blue);

        public void Color3(byte red, byte green, byte blue) =>
            color3(red, green, blue);

        [DllImport("opengl32.dll", EntryPoint = "glColor3ui")]
        static extern void color3(uint red, uint green, uint blue);

        public void Color3(uint red, uint green, uint blue) =>
            color3(red, green, blue);

        [DllImport("opengl32.dll", EntryPoint = "glColor3us")]
        static extern void color3(ushort red, ushort green, ushort blue);

        public void Color3(ushort red, ushort green, ushort blue) =>
            color3(red, green, blue);

        [DllImport("opengl32.dll", EntryPoint = "glColor4b")]
        static extern void color4(sbyte red, sbyte green, sbyte blue, sbyte alpha);

        public void Color4(sbyte red, sbyte green, sbyte blue, sbyte alpha) =>
            color4(red, green, blue, alpha);

        [DllImport("opengl32.dll", EntryPoint = "glColor4d")]
        static extern void color4(double red, double green, double blue, double alpha);

        public void Color4(double red, double green, double blue, double alpha) =>
            color4(red, green, blue, alpha);

        [DllImport("opengl32.dll", EntryPoint = "glColor4f")]
        static extern void color4(float red, float green, float blue, float alpha);

        public void Color4(float red, float green, float blue, float alpha) =>
            color4(red, green, blue, alpha);

        [DllImport("opengl32.dll", EntryPoint = "glColor4i")]
        static extern void color4(int red, int green, int blue, int alpha);

        public void Color4(int red, int green, int blue, int alpha) =>
            color4(red, green, blue, alpha);

        [DllImport("opengl32.dll", EntryPoint = "glColor4s")]
        static extern void color4(short red, short green, short blue, short alpha);

        public void Color4(short red, short green, short blue, short alpha) =>
            color4(red, green, blue, alpha);

        [DllImport("opengl32.dll", EntryPoint = "glColor4ub")]
        static extern void color4(byte red, byte green, byte blue, byte alpha);

        public void Color4(byte red, byte green, byte blue, byte alpha) =>
            color4(red, green, blue, alpha);

        [DllImport("opengl32.dll", EntryPoint = "glColor4ui")]
        static extern void color4(uint red, uint green, uint blue, uint alpha);

        public void Color4(uint red, uint green, uint blue, uint alpha) =>
            color4(red, green, blue, alpha);

        [DllImport("opengl32.dll", EntryPoint = "glColor4us")]
        static extern void color4(ushort red, ushort green, ushort blue, ushort alpha);

        public void Color4(ushort red, ushort green, ushort blue, ushort alpha) =>
            color4(red, green, blue, alpha);

        #endregion

        #region Functions with array pointer parameter import

        [DllImport("opengl32.dll", EntryPoint = "glColor3dv")]
        static extern void Color3dv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glColor3fv")]
        static extern void Color3fv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glColor3iv")]
        static extern void Color3iv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glColor3sv")]
        static extern void Color3sv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glColor3ubv")]
        static extern void Color3bv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glColor4dv")]
        static extern void Color4dv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glColor4fv")]
        static extern void Color4fv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glColor4iv")]
        static extern void Color4iv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glColor4sv")]
        static extern void Color4sv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glColor4ubv")]
        static extern void Color4bv(IntPtr v);

        #endregion

        #region Functions with array pointer parameter wrappers

        public void Color3(sbyte[] v)
        {
            if (v == null || v.Length != HeapData.Color3sbvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(v.Select(x => (byte)(x + sbyte.MaxValue)).ToArray(), 0, HeapData.ptrColor3sbv, v.Length);
            Color4bv(HeapData.ptrColor3sbv);
        }


        public void Color3(double[] v)
        {
            if (v == null || v.Length != HeapData.Color3dvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(v, 0, HeapData.ptrColor3dv, v.Length);
            Color3dv(HeapData.ptrColor3dv);
        }



        public void Color3(float[] v)
        {
            if (v == null || v.Length != HeapData.Color3fvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(v, 0, HeapData.ptrColor3fv, v.Length);
            Color3fv(HeapData.ptrColor3fv);
        }


        public void Color3(int[] v)
        {
            if (v == null || v.Length != HeapData.Color3ivMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(v, 0, HeapData.ptrColor3iv, v.Length);
            Color3iv(HeapData.ptrColor3iv);
        }


        public void Color3(short[] v)
        {
            if (v == null || v.Length != HeapData.Color3svMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(v, 0, HeapData.ptrColor3sv, v.Length);
            Color3sv(HeapData.ptrColor3sv);
        }


        public void Color3(byte[] v)
        {
            if (v == null || v.Length != HeapData.Color3bvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(v, 0, HeapData.ptrColor3bv, v.Length);
            Color3bv(HeapData.ptrColor3bv);
        }

        public void Color3(uint[] v)
        {
            if (v == null || v.Length != HeapData.Color3uivMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(v.Select(x => (int)(x - int.MaxValue)).ToArray(), 0, HeapData.ptrColor3uiv, v.Length);
            Color3iv(HeapData.ptrColor3uiv);
        }


        public void Color3(ushort[] v)
        {
            if (v == null || v.Length != HeapData.Color3usvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(v.Select(x => (short)(x - short.MaxValue)).ToArray(), 0, HeapData.ptrColor3usv, v.Length);
            Color3sv(HeapData.ptrColor3usv);
        }


        public void Color4(sbyte[] v)
        {
            if (v == null || v.Length != HeapData.Color4sbvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(v.Select(x => (byte)(x + byte.MaxValue)).ToArray(), 0, HeapData.ptrColor4sbv, v.Length);
            Color4bv(HeapData.ptrColor4sbv);
        }


        public void Color4(double[] v)
        {
            if (v == null || v.Length != HeapData.Color4dvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(v, 0, HeapData.ptrColor4dv, v.Length);
            Color4dv(HeapData.ptrColor4dv);
        }


        public void Color4(float[] v)
        {
            if (v == null || v.Length != HeapData.Color4fvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(v, 0, HeapData.ptrColor4fv, v.Length);
            Color4fv(HeapData.ptrColor4fv);
        }


        public void Color4(int[] v)
        {
            if (v == null || v.Length != HeapData.Color4ivMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(v, 0, HeapData.ptrColor4iv, v.Length);
            Color4iv(HeapData.ptrColor4iv);
        }


        public void Color4(short[] v)
        {
            if (v == null || v.Length != HeapData.Color4svMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(v, 0, HeapData.ptrColor4sv, v.Length);
            Color4sv(HeapData.ptrColor4sv);
        }


        public void Color4(byte[] v)
        {
            if (v == null || v.Length != HeapData.Color4bvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(v, 0, HeapData.ptrColor4bv, v.Length);
            Color4bv(HeapData.ptrColor4bv);
        }


        public void Color4(uint[] v)
        {
            if (v == null || v.Length != HeapData.Color4uivMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(v.Select(x => (int)(x - int.MaxValue)).ToArray(), 0, HeapData.ptrColor4uiv, v.Length);
            Color4iv(HeapData.ptrColor4uiv);
        }


        public void Color4(ushort[] v)
        {
            if (v == null || v.Length != HeapData.Color4usvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(v.Select(x => (short)(x - short.MaxValue)).ToArray(), 0, HeapData.ptrColor4usv, v.Length);
            Color4sv(HeapData.ptrColor4usv);
        }

        #endregion
    }
}
