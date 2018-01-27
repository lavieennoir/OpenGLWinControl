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
    public static class Glu
    {
        [DllImport("glu32.dll", EntryPoint = "gluPerspective")]
        public static extern void Perspective(double fovy, double aspect, double zNear, double zFar);

    }
}
