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
    public partial class GL
    {
        [DllImport("opengl32.dll", EntryPoint = "glTranslatef")]
        static extern void translate(float x, float y, float z);
        public void Translate(float x, float y, float z)=>
            translate(x, y, z);

        [DllImport("opengl32.dll", EntryPoint = "glTranslated")]
        static extern void translate(double x, double y, double z);
        public void Translate(double x, double y, double z) =>
             translate(x, y, z);

        [DllImport("opengl32.dll", EntryPoint = "glScalef")]
        static extern void scale(float x, float y, float z);
        public void Scale(float x, float y, float z)=>
            scale(x, y, z);

        [DllImport("opengl32.dll", EntryPoint = "glScaled")]
        static extern void scale(double x, double y, double z);
        public void Scale(double x, double y, double z) =>
            scale(x, y, z);

        [DllImport("opengl32.dll", EntryPoint = "glRotatef")]
        static extern void rotate(float angle, float x, float y, float z);
        public void Rotate(float angle, float x, float y, float z)=>
            rotate(angle,  x, y, z);

        [DllImport("opengl32.dll", EntryPoint = "glRotated")]
        static extern void rotate(double angle, double x, double y, double z);
        public void Rotate(double angle, double x, double y, double z) =>
            rotate(angle, x, y, z);
    }
}
