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

        [DllImport("opengl32.dll", EntryPoint = "glRectd")]
        public static extern void Rectd(double x1, double y1, double x2, double y2);

        [DllImport("opengl32.dll", EntryPoint = "glRectf")]
        public static extern void Rectf(float x1, float y1, float x2, float y2);

        [DllImport("opengl32.dll", EntryPoint = "glRecti")]
        public static extern void Recti(int x1, int y1, int x2, int y2);

        [DllImport("opengl32.dll", EntryPoint = "glRects")]
        public static extern void Rects(short x1, short y1, short x2, short y2);
        
        #endregion

        #region Functions with array pointer parameter import

        [DllImport("opengl32.dll", EntryPoint = "glRectdv")]
        private static extern void Rectdv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glRectfv")]
        private static extern void Rectfv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glRectiv")]
        private static extern void Rectiv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glRectsv")]
        private static extern void Rectsv(IntPtr v);
        

        #endregion

        #region Functions with array pointer parameter wrappers

        public static void Rectdv(double[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Rectdv(ptr);
                });


        public static void Rectfv(float[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Rectfv(ptr);
                });


        public static void Rectiv(int[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Rectiv(ptr);
                });


        public static void Rectsv(short[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    Rectsv(ptr);
                });
        
        #endregion
    }
}
