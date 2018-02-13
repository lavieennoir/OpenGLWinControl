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
        [DllImport("opengl32.dll", EntryPoint = "glColorPointer")]
        private static extern void colorPointer(int size, PointerDataType type, int stride, IntPtr array);

        public static void ColorPointer(int size, int stride, byte[] array)
        {
            InvokeWithArrayPointer(ref array,
                (ptr) =>
                {
                    Marshal.Copy(array, 0, ptr, array.Length);
                    colorPointer(size, PointerDataType.BYTE, stride, ptr);
                });
        }

        public static void ColorPointer(int size, int stride, int[] array)
        {
            InvokeWithArrayPointer(ref array,
                (ptr) =>
                {
                    Marshal.Copy(array, 0, ptr, array.Length);
                    colorPointer(size, PointerDataType.INT, stride, ptr);
                });
        }


        public static void ColorPointer(int size, int stride, short[] array)
        {
            InvokeWithArrayPointer(ref array,
                (ptr) =>
                {
                    Marshal.Copy(array, 0, ptr, array.Length);
                    colorPointer(size, PointerDataType.SHORT, stride, ptr);
                });
        }


        public static void ColorPointer(int size, int stride, float[] array)
        {
            InvokeWithArrayPointer(ref array,
                (ptr) =>
                {
                    Marshal.Copy(array, 0, ptr, array.Length);
                    colorPointer(size, PointerDataType.FLOAT, stride, ptr);
                });
        }


        public static void ColorPointer(int size, int stride, double[] array)
        {
            InvokeWithArrayPointer(ref array,
                (ptr) =>
                {
                    Marshal.Copy(array, 0, ptr, array.Length);
                    colorPointer(size, PointerDataType.DOUBLE, stride, ptr);
                });
        }


        public static void ColorPointer(int size, int stride, byte[,] array)
        {
            int height = array.GetLength(0);
            int width = array.GetLength(1);

            byte[] linearArr = new byte[array.Length];
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                    linearArr[i * width + j] = array[i, j];
            InvokeWithArrayPointer(ref linearArr,
                (ptr) =>
                {
                    Marshal.Copy(linearArr, 0, ptr, linearArr.Length);
                    colorPointer(size, PointerDataType.BYTE, stride, ptr);
                });
        }


        public static void ColorPointer(int size, int stride, short[,] array)
        {
            int height = array.GetLength(0);
            int width = array.GetLength(1);

            short[] linearArr = new short[array.Length];
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                    linearArr[i * width + j] = array[i, j];
            InvokeWithArrayPointer(ref linearArr,
                (ptr) =>
                {
                    Marshal.Copy(linearArr, 0, ptr, linearArr.Length);
                    colorPointer(size, PointerDataType.SHORT, stride, ptr);
                });
        }


        public static void ColorPointer(int size, int stride, int[,] array)
        {
            int height = array.GetLength(0);
            int width = array.GetLength(1);

            int[] linearArr = new int[array.Length];
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                    linearArr[i * width + j] = array[i, j];
            InvokeWithArrayPointer(ref linearArr,
                (ptr) =>
                {
                    Marshal.Copy(linearArr, 0, ptr, linearArr.Length);
                    colorPointer(size, PointerDataType.INT, stride, ptr);
                });
        }


        public static void ColorPointer(int size, int stride, float[,] array)
        {
            int height = array.GetLength(0);
            int width = array.GetLength(1);

            float[] linearArr = new float[array.Length];
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                    linearArr[i * width + j] = array[i, j];
            InvokeWithArrayPointer(ref linearArr,
                (ptr) =>
                {
                    Marshal.Copy(linearArr, 0, ptr, linearArr.Length);
                    colorPointer(size, PointerDataType.FLOAT, stride, ptr);
                });
        }


        public static void ColorPointer(int size, int stride, double[,] array)
        {
            int height = array.GetLength(0);
            int width = array.GetLength(1);

            double[] linearArr = new double[array.Length];
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                    linearArr[i * width + j] = array[i, j];
            InvokeWithArrayPointer(ref linearArr,
                (ptr) =>
                {
                    Marshal.Copy(linearArr, 0, ptr, linearArr.Length);
                    colorPointer(size, PointerDataType.DOUBLE, stride, ptr);
                });
        }
    }
}
