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
        [DllImport("opengl32.dll", EntryPoint = "glReadPixels")]
        private static extern void ReadPixels(
            int x, int y, int width, int height, PixelDataFormat format, PixelDataType type, IntPtr pixels);


        public void ReadPixels(
            int x, int y, int width, int height, PixelDataFormat format, byte[] pixels)
        {
            if (pixels == null || pixels.Length > HeapData.ReadPixelsbvMaxSize)
                        throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(pixels, 0, HeapData.ptrReadPixelsbv, pixels.Length);
            ReadPixels(x, y, width, height, format, PixelDataType.BYTE, HeapData.ptrReadPixelsbv);
        }


        public void ReadPixels(
            int x, int y, int width, int height, PixelDataFormat format, sbyte[] pixels)
        {
            if (pixels == null || pixels.Length > HeapData.ReadPixelssbvMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(pixels.Select(i => (byte)i).ToArray(), 0, HeapData.ptrReadPixelssbv, pixels.Length);
            ReadPixels(x, y, width, height, format, PixelDataType.SIGNED_BYTE, HeapData.ptrReadPixelssbv);
        }


        public void ReadPixels(
            int x, int y, int width, int height, PixelDataFormat format, short[] pixels)
        {
            if (pixels == null || pixels.Length > HeapData.ReadPixelssvMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(pixels, 0, HeapData.ptrReadPixelssv, pixels.Length);
            ReadPixels(x, y, width, height, format, PixelDataType.SHORT, HeapData.ptrReadPixelssv);
        }


        public void ReadPixels(
            int x, int y, int width, int height, PixelDataFormat format, ushort[] pixels)
        {
            if (pixels == null || pixels.Length > HeapData.ReadPixelsusvMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(pixels.Select(i => (short)i).ToArray(), 0, HeapData.ptrReadPixelsusv, pixels.Length);
            ReadPixels(x, y, width, height, format, PixelDataType.UNSIGNED_SHORT, HeapData.ptrReadPixelsusv);
        }


        public void ReadPixels(
            int x, int y, int width, int height, PixelDataFormat format, int[] pixels)
        {
            if (pixels == null || pixels.Length > HeapData.ReadPixelsivMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(pixels, 0, HeapData.ptrReadPixelsiv, pixels.Length);
            ReadPixels(x, y, width, height, format, PixelDataType.INT, HeapData.ptrReadPixelsiv);
        }


        public void ReadPixels(
            int x, int y, int width, int height, PixelDataFormat format, uint[] pixels)
        {
            if (pixels == null || pixels.Length > HeapData.ReadPixelsuivMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(pixels.Select(i => (int)i).ToArray(), 0, HeapData.ptrReadPixelsuiv, pixels.Length);
            ReadPixels(x, y, width, height, format, PixelDataType.UNSIGNED_INT, HeapData.ptrReadPixelsuiv);
        }


        public void ReadPixels(
            int x, int y, int width, int height, PixelDataFormat format, float[] pixels)
        {
            if (pixels == null || pixels.Length > HeapData.ReadPixelsfvMaxSize)
                throw new ArgumentException("Array has to many elements.");
            Marshal.Copy(pixels, 0, HeapData.ptrReadPixelsfv, pixels.Length);
            ReadPixels(x, y, width, height, format, PixelDataType.FLOAT, HeapData.ptrReadPixelsfv);
        }
    }
}
