using OpenGLWinControl.OpenGL.HeapData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenGLWinControl.OpenGL
{
    /// <summary>
    /// Containts static methods imported from GLU library.
    /// (Here you can find methods wich have prefix glu in source library)
    /// </summary>
    public class GLU
    {
        public GLUHeapData HeapData;
        

        internal GLU()
        {
            HeapData = new GLUHeapData();
        }

        public void ReallocHeapData(GLUHeapData newData)
        {
            HeapData = newData;
        }


        public void Perspective(double fovy, double aspect, double zNear, double zFar) =>
            perspective(fovy, aspect, zNear, zFar);

        public void Ortho2D(double left, double right, double bottom, double top) =>
            ortho2D(left, right, bottom, top);


        [DllImport("glu32.dll", EntryPoint = "gluPerspective")]
        static extern void perspective(double fovy, double aspect, double zNear, double zFar);

        [DllImport("glu32.dll", EntryPoint = "gluOrtho2D")]
        static extern void ortho2D(double left, double right, double bottom, double top);
    }
}
