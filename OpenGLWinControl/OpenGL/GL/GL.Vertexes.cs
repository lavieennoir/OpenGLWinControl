using OpenGLWinControl.OpenGL.Enumerations.GL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenGLWinControl.OpenGL
{
    public static partial class GL
    {
        #region Functions with value parameters

        [DllImport("opengl32.dll", EntryPoint = "glVertex2d")]
        public static extern void Vertex2(double x, double y);

        [DllImport("opengl32.dll", EntryPoint = "glVertex2f")]
        public static extern void Vertex2(float x, float y);

        [DllImport("opengl32.dll", EntryPoint = "glVertex2i")]
        public static extern void Vertex2(int x, int y);

        [DllImport("opengl32.dll", EntryPoint = "glVertex2s")]
        public static extern void Vertex2(short x, short y);

        [DllImport("opengl32.dll", EntryPoint = "glVertex3d")]
        public static extern void Vertex3(double x, double y, double z);

        [DllImport("opengl32.dll", EntryPoint = "glVertex3f")]
        public static extern void Vertex3(float x, float y, float z);

        [DllImport("opengl32.dll", EntryPoint = "glVertex3i")]
        public static extern void Vertex3(int x, int y, int z);

        [DllImport("opengl32.dll", EntryPoint = "glVertex3s")]
        public static extern void Vertex3(short x, short y, short z);

        [DllImport("opengl32.dll", EntryPoint = "glVertex4d")]
        public static extern void Vertex4(double x, double y, double z, double w);

        [DllImport("opengl32.dll", EntryPoint = "glVertex4f")]
        public static extern void Vertex4(float x, float y, float z, float w);

        [DllImport("opengl32.dll", EntryPoint = "glVertex4i")]
        public static extern void Vertex4(int x, int y, int z, int w);

        [DllImport("opengl32.dll", EntryPoint = "glVertex4s")]
        public static extern void Vertex4(short x, short y, short z, short w);

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

        public static void Vertex2(double[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Vertex2dv(ptr);
                });


        public static void Vertex2(float[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Vertex2fv(ptr);
                });


        public static void Vertex2(int[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Vertex2iv(ptr);
                });


        public static void Vertex2(short[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Vertex2sv(ptr);
                });


        public static void Vertex3(double[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Vertex3dv(ptr);
                });


        public static void Vertex3(float[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Vertex3fv(ptr);
                });


        public static void Vertex3(int[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Vertex3iv(ptr);
                });


        public static void Vertex3(short[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Vertex3sv(ptr);
                });


        public static void Vertex4(double[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Vertex4dv(ptr);
                });


        public static void Vertex4(float[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Vertex4fv(ptr);
                });


        public static void Vertex4(int[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Vertex4iv(ptr);
                });


        public static void Vertex4(short[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Vertex4sv(ptr);
                });


        #endregion
    }
}
