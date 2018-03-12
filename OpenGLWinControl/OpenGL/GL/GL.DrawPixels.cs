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
        [DllImport("opengl32.dll", EntryPoint = "glDrawPixels")]
        private static extern void DrawPixels(
            int width, int height, PixelDataFormat format, PixelDataType type, IntPtr pixels);

                
        public void DrawPixels(
            int width, int height, PixelDataFormat format, byte[] pixels)
        {
            if (pixels == null || pixels.Length > HeapData.DrawPixelsbvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(pixels, 0, HeapData.ptrDrawPixelsbv, pixels.Length);
            DrawPixels(width, height, format, PixelDataType.BYTE, HeapData.ptrDrawPixelsbv);
        }


        public void DrawPixels(
            int width, int height, PixelDataFormat format, sbyte[] pixels)
        {
            if (pixels == null || pixels.Length > HeapData.DrawPixelssbvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(pixels.Select(x => (byte)x).ToArray(), 0, HeapData.ptrDrawPixelssbv, pixels.Length);
            DrawPixels(width, height, format, PixelDataType.SIGNED_BYTE, HeapData.ptrDrawPixelssbv);
        }


        public void DrawPixels(
            int width, int height, PixelDataFormat format, short[] pixels)
        {
            if (pixels == null || pixels.Length > HeapData.DrawPixelssvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(pixels, 0, HeapData.ptrDrawPixelssv, pixels.Length);
            DrawPixels(width, height, format, PixelDataType.SHORT, HeapData.ptrDrawPixelssv);
        }


        public void DrawPixels(

            int width, int height, PixelDataFormat format, ushort[] pixels)
        {
            if (pixels == null || pixels.Length > HeapData.DrawPixelsusvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(pixels.Select(x => (short)x).ToArray(), 0, HeapData.ptrDrawPixelsusv, pixels.Length);
            DrawPixels(width, height, format, PixelDataType.UNSIGNED_SHORT, HeapData.ptrDrawPixelsusv);
        }


        public void DrawPixels(
            int width, int height, PixelDataFormat format, int[] pixels)
        {
            if (pixels == null || pixels.Length > HeapData.DrawPixelsivMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(pixels, 0, HeapData.ptrDrawPixelsiv, pixels.Length);
            DrawPixels(width, height, format, PixelDataType.INT, HeapData.ptrDrawPixelsiv);
        }


        public void DrawPixels(
            int width, int height, PixelDataFormat format, uint[] pixels)
        {
            if (pixels == null || pixels.Length > HeapData.DrawPixelsuivMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(pixels.Select(x => (int)x).ToArray(), 0, HeapData.ptrDrawPixelsuiv, pixels.Length);
            DrawPixels(width, height, format, PixelDataType.UNSIGNED_INT, HeapData.ptrDrawPixelsuiv);
        }


        public void DrawPixels(
           int width, int height, PixelDataFormat format, float[] pixels)
        {
            if (pixels == null || pixels.Length > HeapData.DrawPixelsfvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(pixels, 0, HeapData.ptrDrawPixelsfv, pixels.Length);
            DrawPixels(width, height, format, PixelDataType.FLOAT, HeapData.ptrDrawPixelsfv);
        }
    }
}
