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
        [DllImport("opengl32.dll", EntryPoint = "glIndexPointer")]
        private static extern void indexPointer(PointerDataType type, int stride, IntPtr array);

        public void IndexPointer(int stride, byte[] array)
        {
            if (array == null || array.Length > HeapData.IndexPointerbvMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(array, 0, HeapData.ptrIndexPointerbv, array.Length);
            indexPointer(PointerDataType.BYTE, stride, HeapData.ptrIndexPointerbv);
        }


        public void IndexPointer(int stride, short[] array)
        {
            InvokeWithArrayPointer(ref array,
                (ptr) =>
                {
                    if (array == null || array.Length > HeapData.IndexPointersvMaxSize)
                        throw new ArgumentException("Array has to many elements.");
                    Marshal.Copy(array, 0, HeapData.ptrIndexPointersv, array.Length);
                    indexPointer(PointerDataType.SHORT, stride, HeapData.ptrIndexPointersv);
                });
        }


        public void IndexPointer(int stride, int[] array)
        {
            InvokeWithArrayPointer(ref array,
                (ptr) =>
                {
                    if (array == null || array.Length > HeapData.IndexPointerivMaxSize)
                        throw new ArgumentException("Array has to many elements.");
                    Marshal.Copy(array, 0, HeapData.ptrIndexPointeriv, array.Length);
                    indexPointer(PointerDataType.INT, stride, HeapData.ptrIndexPointeriv);
                });
        }


        public void IndexPointer(int stride, float[] array)
        {
            InvokeWithArrayPointer(ref array,
                (ptr) =>
                {
                    if (array == null || array.Length > HeapData.IndexPointerfvMaxSize)
                        throw new ArgumentException("Array has to many elements.");
                    Marshal.Copy(array, 0, HeapData.ptrIndexPointerfv, array.Length);
                    indexPointer(PointerDataType.FLOAT, stride, HeapData.ptrIndexPointerfv);
                });
        }


        public void IndexPointer(int stride, double[] array)
        {
            InvokeWithArrayPointer(ref array,
                (ptr) =>
                {
                    if (array == null || array.Length > HeapData.IndexPointerdvMaxSize)
                        throw new ArgumentException("Array has to many elements.");
                    Marshal.Copy(array, 0, HeapData.ptrIndexPointerdv, array.Length);
                    indexPointer(PointerDataType.DOUBLE, stride, HeapData.ptrIndexPointerdv);
                });
        }
    }
}
