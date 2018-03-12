using OpenGLWinControl.OpenGL.Enumerations.GL;
using System;
using System.Runtime.InteropServices;

namespace OpenGLWinControl.OpenGL
{
    public partial class GL
    {
        [DllImport("opengl32.dll", EntryPoint = "glVertexPointer")]
        private static extern void vertexPointer(int size, PointerDataType type, int stride, IntPtr array);

        public void VertexPointer(int size, int stride, byte[] array)
        {
            if (array == null || array.Length > HeapData.VertexPointerbvMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(array, 0, HeapData.ptrVertexPointerbv, array.Length);
            vertexPointer(size, PointerDataType.BYTE, stride, HeapData.ptrVertexPointerbv);
        }

        public void VertexPointer(int size, int stride, int[] array)
        {
            if (array == null || array.Length > HeapData.VertexPointerivMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(array, 0, HeapData.ptrVertexPointeriv, array.Length);
            vertexPointer(size, PointerDataType.INT, stride, HeapData.ptrVertexPointeriv);
        }


        public void VertexPointer(int size, int stride, short[] array)
        {
            if (array == null || array.Length > HeapData.VertexPointersvMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(array, 0, HeapData.ptrVertexPointersv, array.Length);
            vertexPointer(size, PointerDataType.SHORT, stride, HeapData.ptrVertexPointersv);
        }


        public void VertexPointer(int size, int stride, float[] array)
        {
            if (array == null || array.Length > HeapData.VertexPointerfvMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(array, 0, HeapData.ptrVertexPointerfv, array.Length);
            vertexPointer(size, PointerDataType.FLOAT, stride, HeapData.ptrVertexPointerfv);
        }


        public void VertexPointer(int size, int stride, double[] array)
        {
            if (array == null || array.Length > HeapData.VertexPointerdvMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(array, 0, HeapData.ptrVertexPointerdv, array.Length);
            vertexPointer(size, PointerDataType.DOUBLE, stride, HeapData.ptrVertexPointerdv);
        }
        
    }
}
