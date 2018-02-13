using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using OpenGLWinControl.OpenGL.Enumerations.GLUT;

namespace OpenGLWinControl.OpenGL
{
    /// <summary>
    /// Containts static methods imported from GLUT library.
    /// (Here you can find methods wich have prefix glut in source library)
    /// </summary>
    public static class GLUT
    {
        [DllImport("glut32.dll", EntryPoint = "glutBitmapCharacter")]
        public static extern void BitmapCharacter(BitmapFont font, char character);


        [DllImport("glut32.dll", EntryPoint = "glutStrokeCharacter")]
        public static extern void StrokeCharacter(StrokeFont font, char character);
    }
}
