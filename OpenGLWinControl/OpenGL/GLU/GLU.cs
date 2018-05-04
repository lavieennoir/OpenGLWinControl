using OpenGLWinControl.OpenGL.Enumerations.GLU;
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

        public class Quadric
        {
            internal IntPtr Data;
        }


        public void Perspective(double fovy, double aspect, double zNear, double zFar) =>
            perspective(fovy, aspect, zNear, zFar);

        [DllImport("glu32.dll", EntryPoint = "gluPerspective")]
        static extern void perspective(double fovy, double aspect, double zNear, double zFar);

        public void Ortho2D(double left, double right, double bottom, double top) =>
            ortho2D(left, right, bottom, top);

        [DllImport("glu32.dll", EntryPoint = "gluOrtho2D")]
        static extern void ortho2D(double left, double right, double bottom, double top);

        public void LookAt(double eyex, double eyey, double eyez,
            double centerx, double centery, double centerz,
            double upx, double upy, double upz) =>
            lookAt(eyex, eyey, eyez,
             centerx, centery, centerz,
             upx, upy, upz);

        [DllImport("glu32.dll", EntryPoint = "gluLookAt")]
        static extern void lookAt(double eyex, double eyey, double eyez,
            double centerx, double centery, double centerz,
            double upx, double upy, double upz);

        public void Cylinder(Quadric obj, double baseRadius, double topRadius,
            double height, int slices, int stacks) =>
           cylinder(obj.Data, baseRadius, topRadius,
            height, slices, stacks);

        [DllImport("glu32.dll", EntryPoint = "gluCylinder")]
        static extern void cylinder(IntPtr obj, double baseRadius, double topRadius,
            double height, int slices, int stacks);

        public Quadric NewQuadric() =>
            new Quadric { Data = newQuadric() };

        [DllImport("glu32.dll", EntryPoint = "gluNewQuadric")]
        static extern IntPtr newQuadric();

        public void DeleteQuadric(Quadric obj) =>
            deleteQuadric(obj.Data);

        [DllImport("glu32.dll", EntryPoint = "gluDeleteQuadric")]
        static extern void deleteQuadric(IntPtr obj);

        public void QuadricDrawStyle(Quadric obj, QuadricDrawStyle style) =>
            quadricDrawStyle(obj.Data, style);

        [DllImport("glu32.dll", EntryPoint = "gluQuadricDrawStyle")]
        static extern void quadricDrawStyle(IntPtr obj, QuadricDrawStyle style);

        public void Disk(Quadric obj, double inner, double outer, int slices, int loops) =>
            disk(obj.Data, inner, outer, slices, loops);

        [DllImport("glu32.dll", EntryPoint = "gluDisk")]
        static extern void disk(IntPtr obj, double inner, double outer, int slices, int loops);
    }
}
