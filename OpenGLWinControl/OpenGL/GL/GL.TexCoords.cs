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

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1d")]
        static extern void TexCoord1d(double s);
        public void TexCoord1(double s) =>
            TexCoord1d(s);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1f")]
        static extern void TexCoord1f(float s);
        public void TexCoord1(float s) =>
            TexCoord1f(s);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1i")]
        static extern void TexCoord1i(int s);
        public void TexCoord1(int s) =>
            TexCoord1i(s);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1s")]
        static extern void TexCoord1s(short s);
        public void TexCoord1(short s) =>
            TexCoord1s(s);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2d")]
        static extern void TexCoord2d(double s, double t);
        public void TexCoord2(double s, double t) =>
            TexCoord2d(s, t);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2f")]
        static extern void TexCoord2f(float s, float t);
        public void TexCoord2(float s, float t) =>
            TexCoord2f(s, t);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2i")]
        static extern void TexCoord2i(int s, int t);
        public void TexCoord2(int s, int t) =>
            TexCoord2i(s, t);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2s")]
        static extern void TexCoord2s(short s, short t);
        public void TexCoord2(short s, short t) =>
            TexCoord2s(s, t);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3d")]
        static extern void TexCoord3d(double s, double t, double r);
        public void TexCoord3(double s, double t, double r)=>
            TexCoord3d(s, t, r);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3f")]
        static extern void TexCoord3f(float s, float t, float r);
        public void TexCoord3(float s, float t, float r) =>
            TexCoord3f(s, t, r);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3i")]
        static extern void TexCoord3i(int s, int t, int r);
        public void TexCoord3(int s, int t, int r) =>
            TexCoord3i(s, t, r);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3s")]
        static extern void TexCoord3s(short s, short t, short r);
        public void TexCoord3(short s, short t, short r) =>
            TexCoord3s(s, t, r);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4d")]
        static extern void TexCoord4d(double s, double t, double r, double q);
        public void TexCoord4(double s, double t, double r, double q)=>
             TexCoord4d( s, t, r, q);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4f")]
        static extern void TexCoord4f(float s, float t, float r, float q);
        public void TexCoord4(float s, float t, float r, float q) =>
             TexCoord4f(s, t, r, q);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4i")]
        static extern void TexCoord4i(int s, int t, int r, int q);
        public void TexCoord4(int s, int t, int r, int q) =>
             TexCoord4i(s, t, r, q);

        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4s")]
        static extern void TexCoord4s(short s, short t, short r, short q);
        public void TexCoord4(short s, short t, short r, short q) =>
             TexCoord4s(s, t, r, q);

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

        public void TexCoord1dv(double[] v)
        {
            if (v == null || v.Length > HeapData.TexCoord1dvMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrTexCoord1dv, v.Length);
            TexCoord1dv(HeapData.ptrTexCoord1dv);
        }


        public void TexCoord1fv(float[] v)
        {
            if (v == null || v.Length > HeapData.TexCoord1fvMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrTexCoord1fv, v.Length);
            TexCoord1fv(HeapData.ptrTexCoord1fv);
        }


        public void TexCoord1iv(int[] v)
        {
            if (v == null || v.Length > HeapData.TexCoord1ivMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrTexCoord1iv, v.Length);
            TexCoord1iv(HeapData.ptrTexCoord1iv);
        }


        public void TexCoord1sv(short[] v)
        {
            if (v == null || v.Length > HeapData.TexCoord1svMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrTexCoord1sv, v.Length);
            TexCoord1sv(HeapData.ptrTexCoord1sv);
        }


        public void TexCoord2dv(double[] v)
        {
            if (v == null || v.Length > HeapData.TexCoord2dvMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrTexCoord2dv, v.Length);
            TexCoord2dv(HeapData.ptrTexCoord2dv);
        }


        public void TexCoord2fv(float[] v)
        {
            if (v == null || v.Length > HeapData.TexCoord2fvMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrTexCoord2fv, v.Length);
            TexCoord2fv(HeapData.ptrTexCoord2fv);
        }


        public void TexCoord2iv(int[] v)
        {
            if (v == null || v.Length > HeapData.TexCoord2ivMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrTexCoord1dv, v.Length);
            TexCoord2iv(HeapData.ptrTexCoord2iv);
        }


        public void TexCoord2sv(short[] v)
        {
            if (v == null || v.Length > HeapData.TexCoord2svMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrTexCoord2sv, v.Length);
            TexCoord2sv(HeapData.ptrTexCoord2sv);
        }


        public void TexCoord3dv(double[] v)
        {
            if (v == null || v.Length > HeapData.TexCoord3dvMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrTexCoord3dv, v.Length);
            TexCoord3dv(HeapData.ptrTexCoord3dv);
        }


        public void TexCoord3fv(float[] v)
        {
            if (v == null || v.Length > HeapData.TexCoord3fvMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrTexCoord3fv, v.Length);
            TexCoord3fv(HeapData.ptrTexCoord3fv);
        }


        public void TexCoord3iv(int[] v)
        {
            if (v == null || v.Length > HeapData.TexCoord3ivMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrTexCoord3iv, v.Length);
            TexCoord3iv(HeapData.ptrTexCoord3iv);
        }


        public void TexCoord3sv(short[] v)
        {
            if (v == null || v.Length > HeapData.TexCoord3svMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrTexCoord3sv, v.Length);
            TexCoord3sv(HeapData.ptrTexCoord3sv);
        }


        public void TexCoord4dv(double[] v)
        {
            if (v == null || v.Length > HeapData.TexCoord4dvMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrTexCoord4dv, v.Length);
            TexCoord4dv(HeapData.ptrTexCoord4dv);
        }


        public void TexCoord4fv(float[] v)
        {
            if (v == null || v.Length > HeapData.TexCoord4fvMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrTexCoord4fv, v.Length);
            TexCoord4fv(HeapData.ptrTexCoord4fv);
        }


        public void TexCoord4iv(int[] v)
        {
            if (v == null || v.Length > HeapData.TexCoord4ivMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrTexCoord4iv, v.Length);
            TexCoord4iv(HeapData.ptrTexCoord4iv);
        }


        public void TexCoord4sv(short[] v)
        {
            if (v == null || v.Length > HeapData.TexCoord4svMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrTexCoord4sv, v.Length);
            TexCoord4sv(HeapData.ptrTexCoord4sv);
        }


        #endregion
    }
}
