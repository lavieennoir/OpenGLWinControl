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

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1d")]
        public static extern void TexCoord1d(double s);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1f")]
        public static extern void TexCoord1f(float s);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1i")]
        public static extern void TexCoord1i(int s);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1s")]
        public static extern void TexCoord1s(short s);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2d")]
        public static extern void TexCoord2d(double s, double t);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2f")]
        public static extern void TexCoord2f(float s, float t);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2i")]
        public static extern void TexCoord2i(int s, int t);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2s")]
        public static extern void TexCoord2s(short s, short t);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3d")]
        public static extern void TexCoord3d(double s, double t, double r);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3f")]
        public static extern void TexCoord3f(float s, float t, float r);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3i")]
        public static extern void TexCoord3i(int s, int t, int r);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3s")]
        public static extern void TexCoord3s(short s, short t, short r);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4d")]
        public static extern void TexCoord4d(double s, double t, double r, double q);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4f")]
        public static extern void TexCoord4f(float s, float t, float r, float q);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4i")]
        public static extern void TexCoord4i(int s, int t, int r, int q);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4s")]
        public static extern void TexCoord4s(short s, short t, short r, short q);

        #endregion

        #region Functions with array pointer parameter import

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1dv")]
        private static extern void TexCoord1dv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1fv")]
        private static extern void TexCoord1fv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1iv")]
        private static extern void TexCoord1iv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1sv")]
        private static extern void TexCoord1sv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2dv")]
        private static extern void TexCoord2dv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2fv")]
        private static extern void TexCoord2fv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2iv")]
        private static extern void TexCoord2iv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2sv")]
        private static extern void TexCoord2sv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3dv")]
        private static extern void TexCoord3dv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3fv")]
        private static extern void TexCoord3fv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3iv")]
        private static extern void TexCoord3iv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3sv")]
        private static extern void TexCoord3sv(IntPtr v);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4dv")]
        private static extern void TexCoord4dv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4fv")]
        private static extern void TexCoord4fv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4iv")]
        private static extern void TexCoord4iv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4sv")]
        private static extern void TexCoord4sv(IntPtr v);


        #endregion

        #region Functions with array pointer parameter wrappers

        public static void TexCoord1dv(double[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    TexCoord1dv(ptr);
                });


        public static void TexCoord1fv(float[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    TexCoord1fv(ptr);
                });


        public static void TexCoord1iv(int[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    TexCoord1iv(ptr);
                });


        public static void TexCoord1sv(short[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    TexCoord1sv(ptr);
                });


        public static void TexCoord2dv(double[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    TexCoord2dv(ptr);
                });


        public static void TexCoord2fv(float[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    TexCoord2fv(ptr);
                });


        public static void TexCoord2iv(int[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    TexCoord2iv(ptr);
                });


        public static void TexCoord2sv(short[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    TexCoord2sv(ptr);
                });


        public static void TexCoord3dv(double[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    TexCoord3dv(ptr);
                });


        public static void TexCoord3fv(float[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    TexCoord3fv(ptr);
                });


        public static void TexCoord3iv(int[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    TexCoord3iv(ptr);
                });


        public static void TexCoord3sv(short[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    TexCoord3sv(ptr);
                });

        
        public static void TexCoord4dv(double[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    TexCoord4dv(ptr);
                });


        public static void TexCoord4fv(float[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    TexCoord4fv(ptr);
                });


        public static void TexCoord4iv(int[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    TexCoord4iv(ptr);
                });


        public static void TexCoord4sv(short[] v) =>
            InvokeWithArrayPointer(v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    TexCoord4sv(ptr);
                });

        
        #endregion
    }
}
