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

        [DllImport("opengl32.dll", EntryPoint = "glVertex2d")]
        public static extern void Vertex2d(double x, double y);

        [DllImport("opengl32.dll", EntryPoint = "glVertex2f")]
        public static extern void Vertex2f(float x, float y);

        [DllImport("opengl32.dll", EntryPoint = "glVertex2i")]
        public static extern void Vertex2i(int x, int y);

        [DllImport("opengl32.dll", EntryPoint = "glVertex2s")]
        public static extern void Vertex2s(short x, short y);

        [DllImport("opengl32.dll", EntryPoint = "glVertex3d")]
        public static extern void Vertex3d(double x, double y, double z);

        [DllImport("opengl32.dll", EntryPoint = "glVertex3f")]
        public static extern void Vertex3f(float x, float y, float z);

        [DllImport("opengl32.dll", EntryPoint = "glVertex3i")]
        public static extern void Vertex3i(int x, int y, int z);

        [DllImport("opengl32.dll", EntryPoint = "glVertex3s")]
        public static extern void Vertex3s(short x, short y, short z);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex4d")]
        public static extern void Vertex4d(double x, double y, double z, double w);

        [DllImport("opengl32.dll", EntryPoint = "glVertex4f")]
        public static extern void Vertex4f(float x, float y, float z, float w);

        [DllImport("opengl32.dll", EntryPoint = "glVertex4i")]
        public static extern void Vertex4i(int x, int y, int z, int w);

        [DllImport("opengl32.dll", EntryPoint = "glVertex4s")]
        public static extern void Vertex4s(short x, short y, short z, short w);

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

        public static void Vertex2dv(double[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Vertex2dv(ptr);
                });


        public static void Vertex2fv(float[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Vertex2fv(ptr);
                });


        public static void Vertex2iv(int[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Vertex2iv(ptr);
                });


        public static void Vertex2sv(short[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Vertex2sv(ptr);
                });


        public static void Vertex3dv(double[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Vertex3dv(ptr);
                });


        public static void Vertex3fv(float[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Vertex3fv(ptr);
                });


        public static void Vertex3iv(int[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Vertex3iv(ptr);
                });


        public static void Vertex3sv(short[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Vertex3sv(ptr);
                });

        
        public static void Vertex4dv(double[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Vertex4dv(ptr);
                });


        public static void Vertex4fv(float[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Vertex4fv(ptr);
                });


        public static void Vertex4iv(int[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Vertex4iv(ptr);
                });


        public static void Vertex4sv(short[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Vertex4sv(ptr);
                });

        
        #endregion
    }
}
