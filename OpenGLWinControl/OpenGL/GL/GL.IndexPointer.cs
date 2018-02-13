using OpenGLWinControl.OpenGL.Enumerations.GL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenGLWinControl.OpenGL
{
    public static partial class GL
    {
        [DllImport("opengl32.dll", EntryPoint = "glIndexPointer")]
        private static extern void indexPointer(PointerDataType type, int stride, IntPtr array);

        public static void IndexPointer(int stride, byte[] array)
        {
            InvokeWithArrayPointer(ref array,
                (ptr) =>
                {
                    Marshal.Copy(array, 0, ptr, array.Length);
                    indexPointer(PointerDataType.BYTE, stride, ptr);
                });
        }


        public static void IndexPointer(int stride, short[] array)
        {
            InvokeWithArrayPointer(ref array,
                (ptr) =>
                {
                    Marshal.Copy(array, 0, ptr, array.Length);
                    indexPointer(PointerDataType.SHORT, stride, ptr);
                });
        }


        public static void IndexPointer(int stride, int[] array)
        {
            InvokeWithArrayPointer(ref array,
                (ptr) =>
                {
                    Marshal.Copy(array, 0, ptr, array.Length);
                    indexPointer(PointerDataType.INT, stride, ptr);
                });
        }


        public static void IndexPointer(int stride, float[] array)
        {
            InvokeWithArrayPointer(ref array,
                (ptr) =>
                {
                    Marshal.Copy(array, 0, ptr, array.Length);
                    indexPointer(PointerDataType.FLOAT, stride, ptr);
                });
        }


        public static void IndexPointer(int stride, double[] array)
        {
            InvokeWithArrayPointer(ref array,
                (ptr) =>
                {
                    Marshal.Copy(array, 0, ptr, array.Length);
                    indexPointer(PointerDataType.DOUBLE, stride, ptr);
                });
        }
    }
}
