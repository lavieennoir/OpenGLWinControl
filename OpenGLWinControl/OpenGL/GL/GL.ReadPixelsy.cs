using OpenGLWinControl.OpenGL.Enumerations.GL;
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
    //  wich starts with glColor
    //
    public static partial class GL
    {
        [DllImport("opengl32.dll", EntryPoint = "glReadPixels")]
        private static extern void ReadPixels(
            int x, int y, int width, int height, PixelDataFormat format, PixelDataType type, IntPtr pixels);


        public static void ReadPixels(
            int x, int y, int width, int height, PixelDataFormat format, byte[] pixels) =>
            InvokeWithArrayPointer(pixels,
                (ptr) => {
                    Marshal.Copy(pixels, 0, ptr, pixels.Length);
                    ReadPixels(x, y, width, height, format, PixelDataType.BYTE, ptr);
                });


        public static void ReadPixels(
            int x, int y, int width, int height, PixelDataFormat format, sbyte[] pixels) =>
            InvokeWithArrayPointer(pixels,
                (ptr) => {
                    Marshal.Copy(pixels.Select(i => (byte)i).ToArray(), 0, ptr, pixels.Length);
                    ReadPixels(x, y, width, height, format, PixelDataType.SIGNED_BYTE, ptr);
                });


        public static void ReadPixels(
            int x, int y, int width, int height, PixelDataFormat format, short[] pixels) =>
            InvokeWithArrayPointer(pixels,
                (ptr) => {
                    Marshal.Copy(pixels, 0, ptr, pixels.Length);
                    ReadPixels(x, y, width, height, format, PixelDataType.SHORT, ptr);
                });


        public static void ReadPixels(
            int x, int y, int width, int height, PixelDataFormat format, ushort[] pixels) =>
            InvokeWithArrayPointer(pixels,
                (ptr) => {
                    Marshal.Copy(pixels.Select(i => (short)i).ToArray(), 0, ptr, pixels.Length);
                    ReadPixels(x, y, width, height, format, PixelDataType.UNSIGNED_SHORT, ptr);
                });


        public static void ReadPixels(
            int x, int y, int width, int height, PixelDataFormat format, int[] pixels) =>
            InvokeWithArrayPointer(pixels,
                (ptr) => {
                    Marshal.Copy(pixels, 0, ptr, pixels.Length);
                    ReadPixels(x, y, width, height, format, PixelDataType.INT, ptr);
                });


        public static void ReadPixels(
            int x, int y, int width, int height, PixelDataFormat format, uint[] pixels) =>
            InvokeWithArrayPointer(pixels,
                (ptr) => {
                    Marshal.Copy(pixels.Select(i => (int)i).ToArray(), 0, ptr, pixels.Length);
                    ReadPixels(x, y, width, height, format, PixelDataType.UNSIGNED_INT, ptr);
                });


        public static void ReadPixels(
            int x, int y, int width, int height, PixelDataFormat format, float[] pixels) =>
           InvokeWithArrayPointer(pixels,
               (ptr) => {
                   Marshal.Copy(pixels, 0, ptr, pixels.Length);
                   ReadPixels(x, y, width, height, format, PixelDataType.FLOAT, ptr);
               });
    }
}
