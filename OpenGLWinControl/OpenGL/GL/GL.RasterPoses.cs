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
    //  for matrix transforms
    //
    public static partial class GL
    {
        #region Functions with value parameters

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2d")]
        public static extern void RasterPos2d(double x, double y);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2f")]
        public static extern void RasterPos2f(float x, float y);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2i")]
        public static extern void RasterPos2i(int x, int y);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2s")]
        public static extern void RasterPos2s(short x, short y);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3d")]
        public static extern void RasterPos3d(double x, double y, double z);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3f")]
        public static extern void RasterPos3f(float x, float y, float z);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3i")]
        public static extern void RasterPos3i(int x, int y, int z);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3s")]
        public static extern void RasterPos3s(short x, short y, short z);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4d")]
        public static extern void RasterPos4d(double x, double y, double z, double w);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4f")]
        public static extern void RasterPos4f(float x, float y, float z, float w);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4i")]
        public static extern void RasterPos4i(int x, int y, int z, int w);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4s")]
        public static extern void RasterPos4s(short x, short y, short z, short w);

        #endregion

        #region Functions with array pointer parameter import

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2dv")]
        private static extern void RasterPos2dv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2fv")]
        private static extern void RasterPos2fv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2iv")]
        private static extern void RasterPos2iv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2sv")]
        private static extern void RasterPos2sv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3dv")]
        private static extern void RasterPos3dv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3fv")]
        private static extern void RasterPos3fv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3iv")]
        private static extern void RasterPos3iv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3sv")]
        private static extern void RasterPos3sv(IntPtr v);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4dv")]
        private static extern void RasterPos4dv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4fv")]
        private static extern void RasterPos4fv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4iv")]
        private static extern void RasterPos4iv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4sv")]
        private static extern void RasterPos4sv(IntPtr v);


        #endregion

        #region Functions with array pointer parameter wrappers

        public static void RasterPos2dv(double[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    RasterPos2dv(ptr);
                });


        public static void RasterPos2fv(float[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    RasterPos2fv(ptr);
                });


        public static void RasterPos2iv(int[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    RasterPos2iv(ptr);
                });


        public static void RasterPos2sv(short[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    RasterPos2sv(ptr);
                });


        public static void RasterPos3dv(double[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    RasterPos3dv(ptr);
                });


        public static void RasterPos3fv(float[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    RasterPos3fv(ptr);
                });


        public static void RasterPos3iv(int[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    RasterPos3iv(ptr);
                });


        public static void RasterPos3sv(short[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    RasterPos3sv(ptr);
                });

        
        public static void RasterPos4dv(double[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    RasterPos4dv(ptr);
                });


        public static void RasterPos4fv(float[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    RasterPos4fv(ptr);
                });


        public static void RasterPos4iv(int[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    RasterPos4iv(ptr);
                });


        public static void RasterPos4sv(short[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    RasterPos4sv(ptr);
                });

        
        #endregion
    }
}
