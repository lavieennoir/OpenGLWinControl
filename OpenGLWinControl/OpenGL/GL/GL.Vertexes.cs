using OpenGLWinControl.OpenGL.Enumerations.GL;
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

        [DllImport("opengl32.dll", EntryPoint = "glVertex2d")]
        static extern void vertex2(double x, double y);
        public void Vertex2(double x, double y)=>
            vertex2(x, y);

        [DllImport("opengl32.dll", EntryPoint = "glVertex2f")]
        static extern void vertex2(float x, float y);
        public void Vertex2(float x, float y) =>
            vertex2(x, y);

        [DllImport("opengl32.dll", EntryPoint = "glVertex2i")]
        static extern void vertex2(int x, int y);
        public void Vertex2(int x, int y) =>
            vertex2(x, y);

        [DllImport("opengl32.dll", EntryPoint = "glVertex2s")]
        static extern void vertex2(short x, short y);
        public void Vertex2(short x, short y) =>
            vertex2(x, y);

        [DllImport("opengl32.dll", EntryPoint = "glVertex3d")]
        static extern void vertex3(double x, double y, double z);
        public void Vertex3(double x, double y, double z)=>
            vertex3(x, y, z);

        [DllImport("opengl32.dll", EntryPoint = "glVertex3f")]
        static extern void vertex3(float x, float y, float z);
        public void Vertex3(float x, float y, float z) =>
            vertex3(x, y, z);

        [DllImport("opengl32.dll", EntryPoint = "glVertex3i")]
        static extern void vertex3(int x, int y, int z);
        public void Vertex3(int x, int y, int z) =>
            vertex3(x, y, z);

        [DllImport("opengl32.dll", EntryPoint = "glVertex3s")]
        static extern void vertex3(short x, short y, short z);
        public void Vertex3(short x, short y, short z) =>
            vertex3(x, y, z);

        [DllImport("opengl32.dll", EntryPoint = "glVertex4d")]
        static extern void vertex4(double x, double y, double z, double w);
        public void Vertex4(double x, double y, double z, double w) =>
            vertex4(x, y, z, w);

        [DllImport("opengl32.dll", EntryPoint = "glVertex4f")]
        static extern void vertex4(float x, float y, float z, float w);
        public void Vertex4(float x, float y, float z, float w) =>
            vertex4(x, y, z, w);

        [DllImport("opengl32.dll", EntryPoint = "glVertex4i")]
        static extern void vertex4(int x, int y, int z, int w);
        public void Vertex4(int x, int y, int z, int w) =>
            vertex4(x, y, z, w);

        [DllImport("opengl32.dll", EntryPoint = "glVertex4s")]
        static extern void vertex4(short x, short y, short z, short w);
        public void Vertex4(short x, short y, short z, short w) =>
            vertex4(x, y, z, w);

        #endregion

        #region Functions with array pointer parameter import

        [DllImport("opengl32.dll", EntryPoint = "glVertex2dv")]
        private static extern void Vertex2dv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glVertex2fv")]
        private static extern void Vertex2fv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glVertex2iv")]
        private static extern void Vertex2iv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glVertex2sv")]
        private static extern void Vertex2sv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glVertex3dv")]
        private static extern void Vertex3dv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glVertex3fv")]
        private static extern void Vertex3fv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glVertex3iv")]
        private static extern void Vertex3iv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glVertex3sv")]
        private static extern void Vertex3sv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glVertex4dv")]
        private static extern void Vertex4dv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glVertex4fv")]
        private static extern void Vertex4fv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glVertex4iv")]
        private static extern void Vertex4iv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glVertex4sv")]
        private static extern void Vertex4sv(IntPtr v);


        #endregion

        #region Functions with array pointer parameter wrappers

        public void Vertex2dv(double[] v)
        {
            if (v == null || v.Length > HeapData.Vertex2dvMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrVertex2dv, v.Length);
            Vertex2dv(HeapData.ptrVertex2dv);
        }


        public void Vertex2fv(float[] v)
        {
            if (v == null || v.Length > HeapData.Vertex2fvMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrVertex2fv, v.Length);
            Vertex2fv(HeapData.ptrVertex2fv);
        }


        public void Vertex2iv(int[] v)
        {
            if (v == null || v.Length > HeapData.Vertex2ivMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrVertex2iv, v.Length);
            Vertex2iv(HeapData.ptrVertex2iv);
        }


        public void Vertex2sv(short[] v)
        {
            if (v == null || v.Length > HeapData.Vertex2svMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrVertex2sv, v.Length);
            Vertex2sv(HeapData.ptrVertex2sv);
        }


        public void Vertex3dv(double[] v)
        {
            if (v == null || v.Length > HeapData.Vertex3dvMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrVertex3dv, v.Length);
            Vertex3dv(HeapData.ptrVertex3dv);
        }


        public void Vertex3fv(float[] v)
        {
            if (v == null || v.Length > HeapData.Vertex3fvMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrVertex3fv, v.Length);
            Vertex3fv(HeapData.ptrVertex3fv);
        }


        public void Vertex3iv(int[] v)
        {
            if (v == null || v.Length > HeapData.Vertex3ivMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrVertex3iv, v.Length);
            Vertex3iv(HeapData.ptrVertex3iv);
        }


        public void Vertex3sv(short[] v)
        {
            if (v == null || v.Length > HeapData.Vertex3svMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrVertex3sv, v.Length);
            Vertex3sv(HeapData.ptrVertex3sv);
        }


        public void Vertex4dv(double[] v)
        {
            if (v == null || v.Length > HeapData.Vertex4dvMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrVertex4dv, v.Length);
            Vertex4dv(HeapData.ptrVertex4dv);
        }


        public void Vertex4fv(float[] v)
        {
            if (v == null || v.Length > HeapData.Vertex4fvMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrVertex4fv, v.Length);
            Vertex4fv(HeapData.ptrVertex4fv);
        }


        public void Vertex4iv(int[] v)
        {
            if (v == null || v.Length > HeapData.Vertex4ivMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrVertex4iv, v.Length);
            Vertex4iv(HeapData.ptrVertex4iv);
        }


        public void Vertex4sv(short[] v)
        {
            if (v == null || v.Length > HeapData.Vertex4svMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrVertex4sv, v.Length);
            Vertex4sv(HeapData.ptrVertex4sv);
        }


        #endregion
    }
}
