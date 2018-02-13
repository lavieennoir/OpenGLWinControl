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
        [DllImport("opengl32.dll", EntryPoint = "glDrawPixels")]
        private static extern void DrawPixels(
            int width, int height, PixelDataFormat format, PixelDataType type, IntPtr pixels);

                
        public static void DrawPixels(
            int width, int height, PixelDataFormat format, byte[] pixels) =>
            InvokeWithArrayPointer(ref pixels,
                (ptr) => {
                    Marshal.Copy(pixels, 0, ptr, pixels.Length);
                    DrawPixels(width, height, format, PixelDataType.BYTE, ptr);
                });


        public static void DrawPixels(
            int width, int height, PixelDataFormat format, sbyte[] pixels) =>
            InvokeWithArrayPointer(ref pixels,
                (ptr) => {
                    Marshal.Copy(pixels.Select(x => (byte)x).ToArray(), 0, ptr, pixels.Length);
                    DrawPixels(width, height, format, PixelDataType.SIGNED_BYTE, ptr);
                });


        public static void DrawPixels(
            int width, int height, PixelDataFormat format, short[] pixels) =>
            InvokeWithArrayPointer(ref pixels,
                (ptr) => {
                    Marshal.Copy(pixels, 0, ptr, pixels.Length);
                    DrawPixels(width, height, format, PixelDataType.SHORT, ptr);
                });


        public static void DrawPixels(
            int width, int height, PixelDataFormat format, ushort[] pixels) =>
            InvokeWithArrayPointer(ref pixels,
                (ptr) => {
                    Marshal.Copy(pixels.Select(x => (short)x).ToArray(), 0, ptr, pixels.Length);
                    DrawPixels(width, height, format, PixelDataType.UNSIGNED_SHORT, ptr);
                });


        public static void DrawPixels(
            int width, int height, PixelDataFormat format, int[] pixels) =>
            InvokeWithArrayPointer(ref pixels,
                (ptr) => {
                    Marshal.Copy(pixels, 0, ptr, pixels.Length);
                    DrawPixels(width, height, format, PixelDataType.INT, ptr);
                });


        public static void DrawPixels(
            int width, int height, PixelDataFormat format, uint[] pixels) =>
            InvokeWithArrayPointer(ref pixels,
                (ptr) => {
                    Marshal.Copy(pixels.Select(x => (int)x).ToArray(), 0, ptr, pixels.Length);
                    DrawPixels(width, height, format, PixelDataType.UNSIGNED_INT, ptr);
                });


        public static void DrawPixels(
           int width, int height, PixelDataFormat format, float[] pixels) =>
           InvokeWithArrayPointer(ref pixels,
               (ptr) => {
                   Marshal.Copy(pixels, 0, ptr, pixels.Length);
                   DrawPixels(width, height, format, PixelDataType.FLOAT, ptr);
               });
    }
}
