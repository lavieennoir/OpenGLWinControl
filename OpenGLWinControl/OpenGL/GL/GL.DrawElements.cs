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
        [DllImport("opengl32.dll", EntryPoint = "glDrawElements")]
        private static extern void DrawElements(
            BeginMode mode, int size, IndexesDataType type, IntPtr indexes);


        public static void DrawElements(BeginMode mode, int size, byte[] indexes)
        {
            InvokeWithArrayPointer(ref indexes,
                (ptr) =>
                {
                    Marshal.Copy(indexes, 0, ptr, indexes.Length);
                    DrawElements(mode, size, IndexesDataType.UNSIGNED_BYTE, ptr);
                });
        }


        public static void DrawElements(BeginMode mode, int size, ushort[] indexes)
        {
            var arr = indexes.Select(x => (short)x).ToArray();
            InvokeWithArrayPointer(ref arr,
                (ptr) =>
                {
                    Marshal.Copy(arr, 0, ptr, arr.Length);
                    DrawElements(mode, size, IndexesDataType.UNSIGNED_SHORT, ptr);
                });
        }


        public static void DrawElements(BeginMode mode, int size, uint[] indexes)
        {
            var arr = indexes.Select(x => (int)x).ToArray();
            InvokeWithArrayPointer(ref arr,
                (ptr) =>
                {
                    Marshal.Copy(arr, 0, ptr, indexes.Length);
                    DrawElements(mode, size, IndexesDataType.UNSIGNED_INT, ptr);
                });
        }
    }
}
