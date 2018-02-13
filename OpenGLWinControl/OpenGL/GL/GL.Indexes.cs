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

        [DllImport("opengl32.dll", EntryPoint = "glIndexd")]
        public static extern void Index(double c);

        [DllImport("opengl32.dll", EntryPoint = "glIndexf")]
        public static extern void Index(float c);

        [DllImport("opengl32.dll", EntryPoint = "glIndexi")]
        public static extern void Index(int c);

        [DllImport("opengl32.dll", EntryPoint = "glIndexs")]
        public static extern void Index(short c);

        [DllImport("opengl32.dll", EntryPoint = "glIndexub")]
        public static extern void Index(byte c);
        
        #endregion

        #region Functions with array pointer parameter import

        [DllImport("opengl32.dll", EntryPoint = "glIndexdv")]
        private static extern void Indexdv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glIndexfv")]
        private static extern void Indexfv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glIndexiv")]
        private static extern void Indexiv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glIndexsv")]
        private static extern void Indexsv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glIndexubv")]
        private static extern void Indexbv(IntPtr v);
        
        #endregion

        #region Functions with array pointer parameter wrappers
        
        public static void Index(double[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Indexdv(ptr);
                });


        public static void Index(float[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Indexfv(ptr);
                });


        public static void Index(int[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Indexiv(ptr);
                });


        public static void Index(short[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Indexsv(ptr);
                });


        public static void Index(byte[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Indexbv(ptr);
                });

        
        #endregion
    }
}
