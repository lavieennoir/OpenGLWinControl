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
        public static extern void Color3sb(sbyte red, sbyte green, sbyte blue);

        [DllImport("opengl32.dll", EntryPoint = "glColor3d")]
        public static extern void Color3d(double red, double green, double blue);

        [DllImport("opengl32.dll", EntryPoint = "glColor3f")]
        public static extern void Color3f(float red, float green, float blue);

        [DllImport("opengl32.dll", EntryPoint = "glColor3i")]
        public static extern void Color3i(int red, int green, int blue);

        [DllImport("opengl32.dll", EntryPoint = "glColor3s")]
        public static extern void Color3s(short red, short green, short blue);

        [DllImport("opengl32.dll", EntryPoint = "glColor3ub")]
        public static extern void Color3b(byte red, byte green, byte blue);

        [DllImport("opengl32.dll", EntryPoint = "glColor3ui")]
        public static extern void Color3ui(uint red, uint green, uint blue);

        [DllImport("opengl32.dll", EntryPoint = "glColor3us")]
        public static extern void Color3us(ushort red, ushort green, ushort blue);

        [DllImport("opengl32.dll", EntryPoint = "glColor4b")]
        public static extern void Color4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);

        [DllImport("opengl32.dll", EntryPoint = "glColor4d")]
        public static extern void Color4d(double red, double green, double blue, double alpha);

        [DllImport("opengl32.dll", EntryPoint = "glColor4f")]
        public static extern void Color4f(float red, float green, float blue, float alpha);

        [DllImport("opengl32.dll", EntryPoint = "glColor4i")]
        public static extern void Color4i(int red, int green, int blue, int alpha);

        [DllImport("opengl32.dll", EntryPoint = "glColor4s")]
        public static extern void Color4s(short red, short green, short blue, short alpha);

        [DllImport("opengl32.dll", EntryPoint = "glColor4ub")]
        public static extern void Color4ub(byte red, byte green, byte blue, byte alpha);

        [DllImport("opengl32.dll", EntryPoint = "glColor4ui")]
        public static extern void Color4ui(uint red, uint green, uint blue, uint alpha);

        [DllImport("opengl32.dll", EntryPoint = "glColor4us")]
        public static extern void Color4us(ushort red, ushort green, ushort blue, ushort alpha);

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

        public static void Color3sbv(sbyte[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v.Select(x => (byte)(x - sbyte.MinValue)).ToArray(), 0, ptr, v.Length);
                    Color3bv(ptr);
                });


        public static void Color3dv(double[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Color3dv(ptr);
                });


        public static void Color3fv(float[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Color3fv(ptr);
                });


        public static void Color3iv(int[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Color3iv(ptr);
                });


        public static void Color3sv(short[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Color3sv(ptr);
                });


        public static void Color3bv(byte[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Color3bv(ptr);
                });


        public static void Color3uiv(uint[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v.Select(x => (int)(x + int.MinValue)).ToArray(), 0, ptr, v.Length);
                    Color3iv(ptr);
                });


        public static void Color3usv(ushort[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v.Select(x => (short)(x + short.MinValue)).ToArray(), 0, ptr, v.Length);
                    Color3sv(ptr);
                });


        public static void Color4sbv(sbyte[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v.Select(x => (byte)(x - sbyte.MinValue)).ToArray(), 0, ptr, v.Length);
                    Color4bv(ptr);
                });


        public static void Color4dv(double[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Color4dv(ptr);
                });


        public static void Color4fv(float[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Color4fv(ptr);
                });


        public static void Color4iv(int[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Color4iv(ptr);
                });


        public static void Color4sv(short[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Color4sv(ptr);
                });


        public static void Color4bv(byte[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Color4bv(ptr);
                });


        public static void Color4uiv(uint[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v.Select(x => (int)(x + int.MinValue)).ToArray(), 0, ptr, v.Length);
                    Color4iv(ptr);
                });


        public static void Color4usv(ushort[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v.Select(x => (short)(x - short.MinValue)).ToArray(), 0, ptr, v.Length);
                    Color4sv(ptr);
                });

        #endregion
    }
}
