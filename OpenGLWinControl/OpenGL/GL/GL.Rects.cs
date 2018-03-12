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

        [DllImport("opengl32.dll", EntryPoint = "glRectd")]
        static extern void rectd(double x1, double y1, double x2, double y2);
        public void Rect(double x1, double y1, double x2, double y2) =>
             rectd(x1, y1, x2, y2);

        [DllImport("opengl32.dll", EntryPoint = "glRectf")]
        static extern void rectf(float x1, float y1, float x2, float y2);
        public void Rect(float x1, float y1, float x2, float y2) =>
             rectf(x1, y1, x2, y2);

        [DllImport("opengl32.dll", EntryPoint = "glRecti")]
        static extern void recti(int x1, int y1, int x2, int y2);
        public void Rect(int x1, int y1, int x2, int y2) =>
             recti(x1, y1, x2, y2);

        [DllImport("opengl32.dll", EntryPoint = "glRects")]
        static extern void rects(short x1, short y1, short x2, short y2);
        public void Rect(short x1, short y1, short x2, short y2) =>
             rects(x1, y1, x2, y2);

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

        public void Rectdv(double[] v)
        {
            if (v == null || v.Length > HeapData.RectdvMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrRectdv, v.Length);
            Rectdv(HeapData.ptrRectdv);
        }


        public void Rectfv(float[] v)
        {
            if (v == null || v.Length > HeapData.RectfvMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrRectfv, v.Length);
            Rectfv(HeapData.ptrRectfv);
        }


        public void Rectiv(int[] v)
        {
            if (v == null || v.Length > HeapData.RectivMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrRectiv, v.Length);
            Rectiv(HeapData.ptrRectiv);
        }


        public void Rectsv(short[] v)
        {
            if (v == null || v.Length > HeapData.RectsvMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(v, 0, HeapData.ptrRectsv, v.Length);
            Rectsv(HeapData.ptrRectsv);
        }
        
        #endregion
    }
}
