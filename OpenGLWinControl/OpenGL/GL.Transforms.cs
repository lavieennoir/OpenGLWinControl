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
        [DllImport("opengl32.dll", EntryPoint = "glTranslatef")]
        public static extern void Translate(float x, float y, float z);

        [DllImport("opengl32.dll", EntryPoint = "glTranslated")]
        public static extern void Translate(double x, double y, double z);

        [DllImport("opengl32.dll", EntryPoint = "glScalef")]
        public static extern void Scale(float x, float y, float z);

        [DllImport("opengl32.dll", EntryPoint = "glScaled")]
        public static extern void Scale(double x, double y, double z);

        [DllImport("opengl32.dll", EntryPoint = "glRotatef")]
        public static extern void Rotate(float x, float y, float z);

        [DllImport("opengl32.dll", EntryPoint = "glRotated")]
        public static extern void Rotate(double x, double y, double z);
    }
}
