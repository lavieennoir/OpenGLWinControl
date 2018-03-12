using OpenGLWinControl.OpenGL.Enumerations.GL;
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
        [DllImport("opengl32.dll", EntryPoint = "glColorPointer")]
        static extern void colorPointer(int size, PointerDataType type, int stride, IntPtr array);

        public void ColorPointer(int size, int stride, byte[] array)
        {
            if (array == null || array.Length > HeapData.ColorPointerbvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(array, 0, HeapData.ptrColorPointerbv, array.Length);
            colorPointer(size, PointerDataType.BYTE, stride, HeapData.ptrColorPointerbv);
        }

        public void ColorPointer(int size, int stride, int[] array)
        {
            if (array == null || array.Length > HeapData.ColorPointerivMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(array, 0, HeapData.ptrColorPointeriv, array.Length);
            colorPointer(size, PointerDataType.INT, stride, HeapData.ptrColorPointeriv);
        }


        public void ColorPointer(int size, int stride, short[] array)
        {
            if (array == null || array.Length > HeapData.ColorPointersvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(array, 0, HeapData.ptrColorPointersv, array.Length);
            colorPointer(size, PointerDataType.SHORT, stride, HeapData.ptrColorPointersv);
        }


        public void ColorPointer(int size, int stride, float[] array)
        {
            if (array == null || array.Length > HeapData.ColorPointerfvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(array, 0, HeapData.ptrColorPointerfv, array.Length);
            colorPointer(size, PointerDataType.FLOAT, stride, HeapData.ptrColorPointerfv);
        }


        public void ColorPointer(int size, int stride, double[] array)
        {
            if (array == null || array.Length > HeapData.ColorPointerdvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(array, 0, HeapData.ptrColorPointerdv, array.Length);
            colorPointer(size, PointerDataType.DOUBLE, stride, HeapData.ptrColorPointerdv);
        }

    }
}
