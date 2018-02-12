using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OpenGLWinControl.OpenGL.Enumerations;

namespace OpenGLWinControl.OpenGL
{
    /// <summary>
    /// Containts static methods imported from OpenGL library.
    /// (Here you can find methods wich have prefix gl in source library)
    /// </summary>
    public static partial class GL
    {
        /// <summary>
        ///     Allocates empty area of memory with size of input array 
        ///     and provides safe pointer to this memory. 
        ///     Pointer will be relesed after function call. 
        /// </summary>
        /// <typeparam name="T">
        ///     Type of an item of input array.
        /// </typeparam>
        /// <param name="arr">
        ///     Array that will be casted to IntPtr.
        /// </param>
        /// <param name="safePtrAction">
        ///     Action with pointer you got.
        /// </param>
        private static void InvokeWithArrayPointer<T>(T[] arr, Action<IntPtr> safePtrAction)
        {
            if (arr == null || arr.Length <= 1)
                throw new ArgumentException("Array has ont enough arguments.");
            int size = Marshal.SizeOf(arr[0]) * arr.Length;
            IntPtr ptr = Marshal.AllocHGlobal(size);
            try
            {
                safePtrAction(ptr);
            }
            catch (Exception e)
            {
                Marshal.FreeHGlobal(ptr);
                throw new ArgumentException("Can`t cast to unmanaged array.", e);
            }
        }


        #region Function import

        //A


        //B


        [DllImport("opengl32.dll", EntryPoint = "glBegin")]
        public static extern void Begin(BeginMode mode);


        [DllImport("opengl32.dll", EntryPoint = "glBlendFunc")]
        public static extern void BlendFunc(BlendingFactor sfactor, BlendingFactor dfactor);


        //C


        [DllImport("opengl32.dll", EntryPoint = "glClear")]
        public static extern void Clear(AttributeMask mask);


        [DllImport("opengl32.dll", EntryPoint = "glClearColor")]
        public static extern void ClearColor(float red, float green, float blue, float alpha);


        [DllImport("opengl32.dll", EntryPoint = "glClearDepth")]
        public static extern void ClearDepth(double depth);


        //D


        [DllImport("opengl32.dll", EntryPoint = "glDepthFunc")]
        public static extern void DepthFunc(AlphaFunction func);


        [DllImport("opengl32.dll", EntryPoint = "glDisable")]
        public static extern void Disable(Capability cap);


        //E


        [DllImport("opengl32.dll", EntryPoint = "glEnable")]
        public static extern void Enable(Capability cap);


        [DllImport("opengl32.dll", EntryPoint = "glEnd")]
        public static extern void End();


        //F


        //G


        [DllImport("opengl32.dll", EntryPoint = "glGetError")]
        public static extern ErrorCode GetError();


        //H


        [DllImport("opengl32.dll", EntryPoint = "glHint")]
        public static extern void Hint(HintTarget target, HintMode mode);


        //I


        //J


        //K


        //L

            
        [DllImport("opengl32.dll", EntryPoint = "glLoadIdentity")]
        public static extern void LoadIdentity();


        //M


        [DllImport("opengl32.dll", EntryPoint = "glMatrixMode")]
        public static extern void MatrixMode(MatrixMode mode);


        //N


        //O


        [DllImport("opengl32.dll", EntryPoint = "glOrtho")]
        public static extern void Ortho(double left, double right,
            double bottom, double top, double zNear, double zFar);


        //P


        [DllImport("opengl32.dll", EntryPoint = "glPopMatrix")]
        public static extern void PopMatrix();


        [DllImport("opengl32.dll", EntryPoint = "glPushMatrix")]
        public static extern void PushMatrix();


        //Q


        //R


        //S


        [DllImport("opengl32.dll", EntryPoint = "glShadeModel")]
        public static extern void ShadeModel(ShadingModel mode);


        //T


        //U


        //V


        [DllImport("opengl32.dll", EntryPoint = "glViewport")]
        public static extern void Viewport(int x, int y, uint width, uint height);


        //W


        //X


        //Y


        //Z
        

        #endregion
    }
}
