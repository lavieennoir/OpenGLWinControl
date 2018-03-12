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
        [DllImport("opengl32.dll", EntryPoint = "glDrawElements")]
        private static extern void DrawElements(
            BeginMode mode, int size, IndexesDataType type, IntPtr indexes);


        public void DrawElements(BeginMode mode, int size, byte[] indexes)
        {
            if (indexes == null || indexes.Length > HeapData.DrawElementsbvMaxSize)
                throw new ArgumentException("Array has to many elements.");
            
            Marshal.Copy(indexes, 0, HeapData.ptrDrawElementsbv, indexes.Length);
            DrawElements(mode, size, IndexesDataType.UNSIGNED_BYTE, HeapData.ptrDrawElementsbv);
            
        }


        public void DrawElements(BeginMode mode, int size, ushort[] indexes)
        {
            var arr = indexes.Select(x => (short)x).ToArray();

            if (arr == null || arr.Length > HeapData.DrawElementsusvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(arr, 0, HeapData.ptrDrawElementsusv, indexes.Length);
            DrawElements(mode, size, IndexesDataType.UNSIGNED_SHORT, HeapData.ptrDrawElementsusv);
        }


        public void DrawElements(BeginMode mode, int size, uint[] indexes)
        {
            var arr = indexes.Select(x => (int)x).ToArray();
            if (arr == null || arr.Length > HeapData.DrawElementsuivMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(arr, 0, HeapData.ptrDrawElementsuiv, indexes.Length);
            DrawElements(mode, size, IndexesDataType.UNSIGNED_INT, HeapData.ptrDrawElementsuiv);
        }
    }
}
