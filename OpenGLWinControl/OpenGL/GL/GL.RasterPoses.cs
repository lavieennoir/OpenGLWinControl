using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenGLWinControl.OpenGL
{
    public partial class GL
    {
        #region Functions with value parameters

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2d")]
        static extern void rasterPos2d(double x, double y);
        public void RasterPos2(double x, double y) =>
            rasterPos2d(x, y);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2f")]
        static extern void rasterPos2f(float x, float y);
        public void RasterPos2(float x, float y) =>
            rasterPos2f(x, y);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2i")]
        static extern void rasterPos2i(int x, int y);
        public void RasterPos2(int x, int y) =>
            rasterPos2f(x, y);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2s")]
        static extern void rasterPos2s(short x, short y);
        public void RasterPos2(short x, short y) =>
            rasterPos2f(x, y);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3d")]
        static extern void rasterPos3d(double x, double y, double z);
        public void RasterPos3(double x, double y, double z) =>
            rasterPos3d(x, y, z);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3f")]
        static extern void rasterPos3f(float x, float y, float z);
        public void RasterPos3(float x, float y, float z) =>
            rasterPos3d(x, y, z);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3i")]
        static extern void rasterPos3i(int x, int y, int z);
        public void RasterPos3(int x, int y, int z) =>
            rasterPos3d(x, y, z);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3s")]
        static extern void rasterPos3s(short x, short y, short z);
        public void RasterPos3(short x, short y, short z) =>
            rasterPos3d(x, y, z);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4d")]
        static extern void rasterPos4d(double x, double y, double z, double w);
        public void RasterPos4(double x, double y, double z, double w) =>
            rasterPos4d(x, y, z, w);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4f")]
        static extern void rasterPos4f(float x, float y, float z, float w);
        public void RasterPos4(float x, float y, float z, float w) =>
            rasterPos4d(x, y, z, w);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4i")]
        static extern void rasterPos4i(int x, int y, int z, int w);
        public void RasterPos4(int x, int y, int z, int w) =>
            rasterPos4d(x, y, z, w);

        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4s")]
        static extern void rasterPos4s(short x, short y, short z, short w);
        public void RasterPos4(short x, short y, short z, short w) =>
            rasterPos4d(x, y, z, w);

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

        public void RasterPos2dv(double[] v)
        {
            if (v == null || v.Length > HeapData.RasterPos2dvMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrRasterPos2dv, v.Length);
            RasterPos2dv(HeapData.ptrRasterPos2dv);
        }


        public void RasterPos2fv(float[] v)
        {
            if (v == null || v.Length > HeapData.RasterPos2fvMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrRasterPos2fv, v.Length);
            RasterPos2fv(HeapData.ptrRasterPos2fv);
        }


        public void RasterPos2iv(int[] v)
        {
            if (v == null || v.Length > HeapData.RasterPos2ivMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrRasterPos2iv, v.Length);
            RasterPos2iv(HeapData.ptrRasterPos2iv);
        }


        public void RasterPos2sv(short[] v)
        {
            if (v == null || v.Length > HeapData.RasterPos2svMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrRasterPos2sv, v.Length);
            RasterPos2sv(HeapData.ptrRasterPos2sv);
        }


        public void RasterPos3dv(double[] v)
        {
            if (v == null || v.Length > HeapData.RasterPos3dvMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrRasterPos3dv, v.Length);
            RasterPos3dv(HeapData.ptrRasterPos3dv);
        }


        public void RasterPos3fv(float[] v)
        {
            if (v == null || v.Length > HeapData.RasterPos3fvMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrRasterPos3fv, v.Length);
            RasterPos3fv(HeapData.ptrRasterPos3fv);
        }


        public void RasterPos3iv(int[] v)
        {
            if (v == null || v.Length > HeapData.RasterPos3ivMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrRasterPos3iv, v.Length);
            RasterPos3iv(HeapData.ptrRasterPos3iv);
        }


        public void RasterPos3sv(short[] v)
        {
            if (v == null || v.Length > HeapData.RasterPos3svMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrRasterPos3sv, v.Length);
            RasterPos3sv(HeapData.ptrRasterPos3sv);
        }


        public void RasterPos4dv(double[] v)
        {
            if (v == null || v.Length > HeapData.RasterPos4dvMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrRasterPos4dv, v.Length);
            RasterPos4dv(HeapData.ptrRasterPos4dv);
        }


        public void RasterPos4fv(float[] v)
        {
            if (v == null || v.Length > HeapData.RasterPos4fvMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrRasterPos4fv, v.Length);
            RasterPos4fv(HeapData.ptrRasterPos4fv);
        }


        public void RasterPos4iv(int[] v)
        {
            if (v == null || v.Length > HeapData.RasterPos4ivMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrRasterPos4iv, v.Length);
            RasterPos4iv(HeapData.ptrRasterPos4iv);
        }


        public void RasterPos4sv(short[] v)
        {
            if (v == null || v.Length > HeapData.RasterPos4svMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrRasterPos4sv, v.Length);
            RasterPos4sv(HeapData.ptrRasterPos4sv);
        }


        #endregion
    }
}
