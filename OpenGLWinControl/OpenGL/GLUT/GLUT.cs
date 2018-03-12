using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using OpenGLWinControl.OpenGL.Enumerations.GLUT;
using OpenGLWinControl.OpenGL.HeapData;

namespace OpenGLWinControl.OpenGL
{
    /// <summary>
    /// Containts static methods imported from GLUT library.
    /// (Here you can find methods wich have prefix glut in source library)
    /// </summary>
    public class GLUT
    {
        public GLUTHeapData HeapData;
        

        internal GLUT()
        {
            HeapData = new GLUTHeapData();
        }

        public void ReallocHeapData(GLUTHeapData newData)
        {
            HeapData = newData;
        }

        public void BitmapCharacter(BitmapFont font, char character) =>
            bitmapCharacter(font, character);

        public void StrokeCharacter(StrokeFont font, char character) =>
            strokeCharacter(font, character);

        [DllImport("glut32.dll", EntryPoint = "glutBitmapCharacter")]
        static extern void bitmapCharacter(BitmapFont font, char character);


        [DllImport("glut32.dll", EntryPoint = "glutStrokeCharacter")]
        static extern void strokeCharacter(StrokeFont font, char character);
    }
}
