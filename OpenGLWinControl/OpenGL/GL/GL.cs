using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OpenGLWinControl.OpenGL.Enumerations.GL;

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
        private static void InvokeWithArrayPointer<T>(ref T[] arr, Action<IntPtr> safePtrAction)
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


        [DllImport("opengl32.dll", EntryPoint = "glArrayElement")]
        public static extern void ArrayElement(int i);


        //B


        [DllImport("opengl32.dll", EntryPoint = "glBitmap")]
        private static extern void Bitmap(
            int width, int height, float xOrig, float yOrig,
            float xMove, float yMove, IntPtr bitmap);

        public static void Bitmap(int width, int height, float xOrig, float yOrig,
            float xMove, float yMove, byte[] bitmap) =>
            InvokeWithArrayPointer(ref bitmap,
                (ptr) => {
                    Marshal.Copy(bitmap, 0, ptr, bitmap.Length);
                    Bitmap(width, height, xOrig, yOrig,
                        xMove, yMove, ptr);
                });


        [DllImport("opengl32.dll", EntryPoint = "glBegin")]
        public static extern void Begin(BeginMode mode);


        [DllImport("opengl32.dll", EntryPoint = "glBlendFunc")]
        public static extern void BlendFunc(BlendingFactor sfactor, BlendingFactor dfactor);


        //C


        [DllImport("opengl32.dll", EntryPoint = "glCallList")]
        public static extern void CallList(uint list);


        [DllImport("opengl32.dll", EntryPoint = "glClear")]
        public static extern void Clear(ClearAttributeMask mask);


        [DllImport("opengl32.dll", EntryPoint = "glClearAccum")]
        public static extern void ClearAccum(float red, float green, float blue, float alpha);


        [DllImport("opengl32.dll", EntryPoint = "glClearColor")]
        public static extern void ClearColor(float red, float green, float blue, float alpha);


        [DllImport("opengl32.dll", EntryPoint = "glClearDepth")]
        public static extern void ClearDepth(double depth);


        [DllImport("opengl32.dll", EntryPoint = "glClearIndex")]
        public static extern void ClearIndex(float c);


        [DllImport("opengl32.dll", EntryPoint = "glClearStencil")]
        public static extern void ClearStencil(int s);


        [DllImport("opengl32.dll", EntryPoint = "glCopyPixels")]
        public static extern void CopyPixels(int x, int y, int width, int height, PixelCopyType type);


        //D


        [DllImport("opengl32.dll", EntryPoint = "glDeleteLists")]
        public static extern void DeleteLists(uint list, int range);


        [DllImport("opengl32.dll", EntryPoint = "glDepthFunc")]
        public static extern void DepthFunc(AlphaFunction func);


        [DllImport("opengl32.dll", EntryPoint = "glDepthMask")]
        public static extern void DepthMask(bool flag);


        [DllImport("opengl32.dll", EntryPoint = "glDepthRange")]
        public static extern void DepthRange(double zNear, double zFar);


        [DllImport("opengl32.dll", EntryPoint = "glDisable")]
        public static extern void Disable(Capability cap);


        [DllImport("opengl32.dll", EntryPoint = "glDisableClientState")]
        public static extern void DisableClientState(ClientSideCapability cap);



        //E


        [DllImport("opengl32.dll", EntryPoint = "glEdgeFlag")]
        private static extern void EdgeFlag(byte flag);

        public static void EdgeFlag(bool flag) =>
            EdgeFlag(flag ? (byte)1 : (byte)0);
        

        [DllImport("opengl32.dll", EntryPoint = "glEdgeFlag")]
        private static extern void EdgeFlag(byte[] flag);

        public static void EdgeFlag(bool[] flag) =>
            EdgeFlag(flag.Select(x => x ? (byte)1 : (byte)0).ToArray());


        [DllImport("opengl32.dll", EntryPoint = "glEnable")]
        public static extern void Enable(Capability cap);


        [DllImport("opengl32.dll", EntryPoint = "glEnableClientState")]
        public static extern void EnableClientState(ClientSideCapability cap);


        [DllImport("opengl32.dll", EntryPoint = "glEnd")]
        public static extern void End();


        [DllImport("opengl32.dll", EntryPoint = "glEndList")]
        public static extern void EndList();


        [DllImport("opengl32.dll", EntryPoint = "glEvalPoint1")]
        public static extern void EvalPoint1(int i);

        [DllImport("opengl32.dll", EntryPoint = "glEvalPoint2")]
        public static extern void EvalPoint2(int i, int j);


        //F


        [DllImport("opengl32.dll", EntryPoint = "glFinish")]
        public static extern void Finish();


        [DllImport("opengl32.dll", EntryPoint = "glFlush")]
        public static extern void Flush();


        [DllImport("opengl32.dll", EntryPoint = "glFrustum")]
        public static extern void Frustum(double left, double right, double bottom, double top, double zNear, double zFar);



        //G


        [DllImport("opengl32.dll", EntryPoint = "glGenLists")]
        public static extern uint GenLists(int range);


        [DllImport("opengl32.dll", EntryPoint = "glGetError")]
        public static extern ErrorCode GetError();


        //H


        [DllImport("opengl32.dll", EntryPoint = "glHint")]
        public static extern void Hint(HintTarget target, HintMode mode);


        //I


        [DllImport("opengl32.dll", EntryPoint = "glIndexMask")]
        public static extern void IndexMask(uint mask);


        [DllImport("opengl32.dll", EntryPoint = "glInitNames")]
        public static extern void InitNames();


        [DllImport("opengl32.dll", EntryPoint = "glInterleavedArrays")]
        public static extern void InterleavedArrays(
            InterleavedArrayType format, int stride, int[] pointer);


        [DllImport("opengl32.dll", EntryPoint = "glIsList")]
        private static extern byte isList(uint list);

        public static bool IsList(uint list) => isList(list) != 0;


        [DllImport("opengl32.dll", EntryPoint = "glIsTexture")]
        private static extern byte isTexture(uint texture);

        public static bool IsTexture(uint texture) => isList(texture) != 0;


        //J


        //K


        //L


        [DllImport("opengl32.dll", EntryPoint = "glLineStipple")]
        public static extern void LineStipple(int factor, ushort pattern);


        [DllImport("opengl32.dll", EntryPoint = "glLineWidth")]
        public static extern void LineWidth(float width);


        [DllImport("opengl32.dll", EntryPoint = "glListBase")]
        public static extern void ListBase(uint listBase);


        [DllImport("opengl32.dll", EntryPoint = "glLoadIdentity")]
        public static extern void LoadIdentity();
        

        [DllImport("opengl32.dll", EntryPoint = "glLoadMatrixd")]
        public static extern void LoadMatrix(double[] matrix);


        [DllImport("opengl32.dll", EntryPoint = "glLoadMatrixf")]
        public static extern void LoadMatrix(float[] matrix);


        [DllImport("opengl32.dll", EntryPoint = "glLoadName")]
        public static extern void LoadName(uint name);



        //M


        [DllImport("opengl32.dll", EntryPoint = "glMapGrid1d")]
        public static extern void MapGrid1(int un, double u1, double u2);


        [DllImport("opengl32.dll", EntryPoint = "glMapGrid1f")]
        public static extern void MapGrid1(int un, float u1, float u2);


        [DllImport("opengl32.dll", EntryPoint = "glMapGrid2d")]
        public static extern void MapGrid2(int un, double u1, double u2, int vn, double v1, double v2);


        [DllImport("opengl32.dll", EntryPoint = "glMapGrid2f")]
        public static extern void MapGrid2(int un, float u1, float u2, int vn, float v1, float v2);


        [DllImport("opengl32.dll", EntryPoint = "glMatrixMode")]
        public static extern void MatrixMode(MatrixMode mode);

        
        [DllImport("opengl32.dll", EntryPoint = "glMultMatrixd")]
        public static extern void MultMatrix(double[] martix);


        [DllImport("opengl32.dll", EntryPoint = "glMultMatrixf")]
        public static extern void MultMatrix(float[] matrix);


        //N


        //O


        [DllImport("opengl32.dll", EntryPoint = "glOrtho")]
        public static extern void Ortho(double left, double right,
            double bottom, double top, double zNear, double zFar);


        //P


        [DllImport("opengl32.dll", EntryPoint = "glPassThrough")]
        public static extern void PassThrough(float token);


        [DllImport("opengl32.dll", EntryPoint = "glPixelStoref")]
        public static extern void PixelStore(PixelStoreParam pname, float param);


        [DllImport("opengl32.dll", EntryPoint = "glPixelStorei")]
        public static extern void PixelStore(PixelStoreParam pname, int param);


        [DllImport("opengl32.dll", EntryPoint = "glPixelTransferf")]
        public static extern void PixelTransfer(PixelTransferParam pname, float param);


        [DllImport("opengl32.dll", EntryPoint = "glPixelTransferi")]
        public static extern void PixelTransfer(PixelTransferParam panme, int param);


        [DllImport("opengl32.dll", EntryPoint = "glPixelZoom")]
        public static extern void PixelZoom(float xfactor, float yfactor);


        [DllImport("opengl32.dll", EntryPoint = "glPointSize")]
        public static extern void PointSize(float width);


        [DllImport("opengl32.dll", EntryPoint = "glPolygonMode")]
        public static extern void PolygonMode(FacingMode face, PolygonMode mode);


        [DllImport("opengl32.dll", EntryPoint = "glPolygonOffset")]
        public static extern void PolygonOffset(float factor, float units);


        [DllImport("opengl32.dll", EntryPoint = "glPolygonStipple")]
        public static extern void PolygonStipple(byte[] mask);


        [DllImport("opengl32.dll", EntryPoint = "glPopAttrib")]
        public static extern void PopAttrib();


        [DllImport("opengl32.dll", EntryPoint = "glPopClientAttrib")]
        public static extern void PopClientAttrib();


        [DllImport("opengl32.dll", EntryPoint = "glPopMatrix")]
        public static extern void PopMatrix();


        [DllImport("opengl32.dll", EntryPoint = "glPopName")]
        public static extern void PopName();


        [DllImport("opengl32.dll", EntryPoint = "glPushAttrib")]
        public static extern void PushAttrib(AttributeMask mask);


        [DllImport("opengl32.dll", EntryPoint = "glPushClientAttrib")]
        public static extern void PushClientAttrib(ClientAttributeMask mask);


        [DllImport("opengl32.dll", EntryPoint = "glPushMatrix")]
        public static extern void PushMatrix();


        [DllImport("opengl32.dll", EntryPoint = "glPushName")]
        public static extern void PushName(uint name);


        //Q


        //R


        //S


        [DllImport("opengl32.dll", EntryPoint = "glScissor")]
        public static extern void Scissor(int x, int y, int width, int height);


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
