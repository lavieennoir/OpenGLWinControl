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
        #region Functions with value parameters

        [DllImport("opengl32.dll", EntryPoint = "glIndexd")]
        static extern void index(double c);
        public void Index(double c) =>
            index(c);

        [DllImport("opengl32.dll", EntryPoint = "glIndexf")]
        static extern void index(float c);
        public void Index(float c) =>
            index(c);

        [DllImport("opengl32.dll", EntryPoint = "glIndexi")]
        static extern void index(int c);
        public void Index(int c) =>
            index(c);

        [DllImport("opengl32.dll", EntryPoint = "glIndexs")]
        static extern void index(short c);
        public void Index(short c) =>
            index(c);

        [DllImport("opengl32.dll", EntryPoint = "glIndexub")]
        static extern void index(byte c);
        public void Index(byte c) =>
            index(c);

        #endregion

        #region Functions with array pointer parameter import

        [DllImport("opengl32.dll", EntryPoint = "glIndexdv")]
        private static extern void Indexdv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glIndexfv")]
        private static extern void Indexfv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glIndexiv")]
        private static extern void Indexiv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glIndexsv")]
        private static extern void Indexsv(IntPtr v);

        [DllImport("opengl32.dll", EntryPoint = "glIndexubv")]
        private static extern void Indexbv(IntPtr v);
        
        #endregion

        #region Functions with array pointer parameter wrappers
        
        public void Index(double[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    if (v == null || v.Length > HeapData.IndexdvMaxSize)
                        throw new ArgumentException("Array has to many elements.");

                    Marshal.Copy(v, 0, HeapData.ptrIndexdv, v.Length);
                    Indexdv(HeapData.ptrIndexdv);
                });


        public void Index(float[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    if (v == null || v.Length > HeapData.IndexfvMaxSize)
                        throw new ArgumentException("Array has to many elements.");
                    Marshal.Copy(v, 0, HeapData.ptrIndexfv, v.Length);
                    Indexfv(HeapData.ptrIndexfv);
                });


        public void Index(int[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    if (v == null || v.Length > HeapData.IndexivMaxSize)
                        throw new ArgumentException("Array has to many elements.");
                    Marshal.Copy(v, 0, HeapData.ptrIndexiv, v.Length);
                    Indexiv(HeapData.ptrIndexiv);
                });


        public void Index(short[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    if (v == null || v.Length > HeapData.IndexsvMaxSize)
                        throw new ArgumentException("Array has to many elements.");
                    Marshal.Copy(v, 0, HeapData.ptrIndexsv, v.Length);
                    Indexsv(HeapData.ptrIndexsv);
                });


        public void Index(byte[] v) =>
            InvokeWithArrayPointer(ref v,
                (ptr) => {
                    if (v == null || v.Length > HeapData.IndexdvMaxSize)
                        throw new ArgumentException("Array has to many elements.");
                    Marshal.Copy(v, 0, HeapData.ptrIndexbv, v.Length);
                    Indexbv(HeapData.ptrIndexbv);
                });

        
        #endregion
    }
}
