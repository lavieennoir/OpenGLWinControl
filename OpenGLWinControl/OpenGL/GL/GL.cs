using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OpenGLWinControl.OpenGL.Enumerations.GL;
using OpenGLWinControl.OpenGL.HeapData;

namespace OpenGLWinControl.OpenGL
{
    /// <summary>
    /// Containts static methods imported from OpenGL library.
    /// (Here you can find methods wich have prefix gl in source library).
    /// </summary>
    public partial class GL
    {
        /// <summary>
        ///     Pointers to function arguments of all gl 
        ///     function parameters passed by pointer.
        /// </summary>
        internal GLHeapData HeapData;


        /// <summary>
        ///     Interanl contructor for instantiating in control class.
        /// </summary>
        internal GL()
        {
            HeapData = new GLHeapData();
        }

        /// <summary>
        ///     Update pointer sizes for GL method arguments.
        /// </summary>
        /// <param name="newData">
        ///     New data limits will be set.
        /// </param>
        internal void ReallocHeapData(GLHeapData newData)
        {
            HeapData.Dispose();
            HeapData = newData;
            HeapData.AllocHeapPointers();
        }


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
        static void InvokeWithArrayPointer<T>(ref T[] arr, Action<IntPtr> safePtrAction)
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
        static extern void arrayElement(int i);

        public void ArrayElement(int i) =>
            arrayElement(i);

        //B


        [DllImport("opengl32.dll", EntryPoint = "glBitmap")]
        static extern void Bitmap(
            int width, int height, float xOrig, float yOrig,
            float xMove, float yMove, IntPtr bitmap);

        public void Bitmap(int width, int height, float xOrig, float yOrig,
            float xMove, float yMove, byte[] bitmap)
        {
            if (bitmap == null || bitmap.Length > HeapData.BitmapbvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(bitmap, 0, HeapData.ptrBitmapbv, bitmap.Length);
            Bitmap(width, height, xOrig, yOrig,
                        xMove, yMove, HeapData.ptrBitmapbv);
        }


        [DllImport("opengl32.dll", EntryPoint = "glBindTexture")]
        static extern void bindTexture(GetTarget target, int textureId);

        public void BindTexture(GetTarget target, int textureId) =>
            bindTexture(target, textureId);


        [DllImport("opengl32.dll", EntryPoint = "glBegin")]
        static extern void begin(BeginMode mode);

        public void Begin(BeginMode mode) =>
            begin(mode);


        [DllImport("opengl32.dll", EntryPoint = "glBlendFunc")]
        static extern void blendFunc(BlendingFactor sfactor, BlendingFactor dfactor);

        public void BlendFunc(BlendingFactor sfactor, BlendingFactor dfactor) =>
            blendFunc(sfactor, dfactor);


        //C


        [DllImport("opengl32.dll", EntryPoint = "glCallList")]
        static extern void callList(uint list);

        public void CallList(uint list) =>
            callList(list);


        [DllImport("opengl32.dll", EntryPoint = "glClear")]
        static extern void clear(ClearAttributeMask mask);

        public void Clear(ClearAttributeMask mask) =>
            clear(mask);


        [DllImport("opengl32.dll", EntryPoint = "glClearAccum")]
        static extern void clearAccum(float red, float green, float blue, float alpha);

        public void ClearAccum(float red, float green, float blue, float alpha) =>
            clearAccum(red, green, blue, alpha);


        [DllImport("opengl32.dll", EntryPoint = "glClearColor")]
        static extern void clearColor(float red, float green, float blue, float alpha);

        public void ClearColor(float red, float green, float blue, float alpha) =>
            clearColor(red, green, blue, alpha);


        [DllImport("opengl32.dll", EntryPoint = "glClearDepth")]
        static extern void clearDepth(double depth);

        public void ClearDepth(double depth) =>
            clearDepth(depth);


        [DllImport("opengl32.dll", EntryPoint = "glClearIndex")]
        static extern void clearIndex(float c);

        public void ClearIndex(float c) =>
            clearIndex(c);


        [DllImport("opengl32.dll", EntryPoint = "glClearStencil")]
        static extern void clearStencil(int s);

        public void ClearStencil(int s) =>
            clearStencil(s);


        [DllImport("opengl32.dll", EntryPoint = "glCopyPixels")]
        static extern void copyPixels(int x, int y, int width, int height, PixelCopyType type);

        public void CopyPixels(int x, int y, int width, int height, PixelCopyType type) =>
            copyPixels(x, y, width, height, type);


        //D


        [DllImport("opengl32dll", EntryPoint = "glDeleteLists")]
        static extern void deleteLists(uint list, int range);

        public void DeleteLists(uint list, int range) =>
             deleteLists(list, range);


        [DllImport("opengl32.dll", EntryPoint = "glDepthFunc")]
        static extern void depthFunc(AlphaFunction func);

        public void DepthFunc(AlphaFunction func) =>
            depthFunc(func);


        [DllImport("opengl32.dll", EntryPoint = "glDepthMask")]
        static extern void depthMask(bool flag);

        public void DepthMask(bool flag) =>
             depthMask(flag);


        [DllImport("opengl32.dll", EntryPoint = "glDepthRange")]
        static extern void depthRange(double zNear, double zFar);

        public void DepthRange(double zNear, double zFar) =>
            depthRange(zNear, zFar);


        [DllImport("opengl32.dll", EntryPoint = "glDisable")]
        static extern void disable(Capability cap);

        public void Disable(Capability cap) =>
             disable(cap);


        [DllImport("opengl32.dll", EntryPoint = "glDisableClientState")]
        static extern void disableClientState(ClientSideCapability cap);

        public void DisableClientState(ClientSideCapability cap) =>
             disableClientState(cap);



        //E


        [DllImport("opengl32.dll", EntryPoint = "glEdgeFlag")]
        static extern void edgeFlag(byte flag);

        public void EdgeFlag(bool flag) =>
            edgeFlag(flag ? (byte)1 : (byte)0);


        [DllImport("opengl32.dll", EntryPoint = "glEdgeFlag")]
        static extern void edgeFlag(IntPtr flag);

        public void EdgeFlag(bool[] flag)
        {
            if (flag == null || flag.Length > HeapData.EdgeFlagbvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(flag.Select(x => x ? (byte)1 : (byte)0).ToArray(),
                0, HeapData.ptrEdgeFlagbv, flag.Length);
            edgeFlag(HeapData.ptrEdgeFlagbv);
        }


        [DllImport("opengl32.dll", EntryPoint = "glEnable")]
        static extern void enable(Capability cap);

        public void Enable(Capability cap) =>
            enable(cap);


        [DllImport("opengl32.dll", EntryPoint = "glEnableClientState")]
        static extern void enableClientState(ClientSideCapability cap);

        public void EnableClientState(ClientSideCapability cap) =>
            enableClientState(cap);


        [DllImport("opengl32.dll", EntryPoint = "glEnd")]
        static extern void end();

        public void End() =>
            end();


        [DllImport("opengl32.dll", EntryPoint = "glEndList")]
        static extern void endList();

        public void EndList() =>
            endList();


        [DllImport("opengl32.dll", EntryPoint = "glEvalPoint1")]
        static extern void evalPoint1(int i);

        public void EvalPoint1(int i) =>
            evalPoint1(i);

        [DllImport("opengl32.dll", EntryPoint = "glEvalPoint2")]
        static extern void evalPoint2(int i, int j);

        public void EvalPoint2(int i, int j) =>
            evalPoint2(i, j);


        //F


        [DllImport("opengl32.dll", EntryPoint = "glFinish")]
        static extern void finish();

        public void Finish() =>
            finish();


        [DllImport("opengl32.dll", EntryPoint = "glFlush")]
        static extern void flush();

        public void Flush() =>
             flush();


        [DllImport("opengl32.dll", EntryPoint = "glFrustum")]
        static extern void frustum(double left, double right, double bottom, double top, double zNear, double zFar);

        public void Frustum(double left, double right, double bottom, double top, double zNear, double zFar) =>
            frustum(left, right, bottom, top, zNear, zFar);



        //G

        [DllImport("opengl32.dll", EntryPoint = "glGenTextures")]
        static extern void genTextures(int n, ref int textureId);

        public void GenTextures(int n, ref int textureId) =>
            genTextures(n, ref textureId);

        [DllImport("opengl32.dll", EntryPoint = "glGenLists")]
        static extern uint genLists(int range);

        public uint GenLists(int range) =>
            genLists(range);


        [DllImport("opengl32.dll", EntryPoint = "glGetError")]
        static extern ErrorCode getError();

        public ErrorCode GetError() =>
            getError();


        //H


        [DllImport("opengl32.dll", EntryPoint = "glHint")]
        static extern void hint(HintTarget target, HintMode mode);

        public void Hint(HintTarget target, HintMode mode) =>
            hint(target, mode);


        //I


        [DllImport("opengl32.dll", EntryPoint = "glIndexMask")]
        static extern void indexMask(uint mask);

        public void IndexMask(uint mask) =>
            indexMask(mask);


        [DllImport("opengl32.dll", EntryPoint = "glInitNames")]
        static extern void initNames();

        public void InitNames() =>
             initNames();


        [DllImport("opengl32.dll", EntryPoint = "glInterleavedArrays")]
        static extern void interleavedArrays(
            InterleavedArrayType format, int stride, IntPtr pointer);

        public void InterleavedArrays(
            InterleavedArrayType format, int stride, int[] pointer)
        {
            if (pointer == null || pointer.Length > HeapData.InterleavedArraysivMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(pointer, 0, HeapData.ptrInterleavedArraysiv, pointer.Length);
            interleavedArrays(format, stride, HeapData.ptrInterleavedArraysiv);
        }


        [DllImport("opengl32.dll", EntryPoint = "glIsList")]
        static extern byte isList(uint list);

        public bool IsList(uint list) => isList(list) != 0;


        [DllImport("opengl32.dll", EntryPoint = "glIsTexture")]
        static extern byte isTexture(uint texture);

        public bool IsTexture(uint texture) => isList(texture) != 0;


        //J


        //K


        //L

        [DllImport("opengl32.dll", EntryPoint = "glLightfv")]
        static extern void lightfv(LightName light, LightParameter pname, IntPtr param);

        public void Lightfv(LightName light, LightParameter pname, float[] param)
        {
            if (param == null || param.Length > HeapData.LightfvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(param, 0, HeapData.ptrLightfv, param.Length);
            lightfv(light, pname, HeapData.ptrLightfv);
        }

        [DllImport("opengl32.dll", EntryPoint = "glLightf")]
        static extern void lightf(LightName light, LightParameter pname, float param);

        public void Lightf(LightName light, LightParameter pname, float param) =>
            lightf(light, pname, param);

        [DllImport("opengl32.dll", EntryPoint = "glLighti")]
        static extern void lighti(LightName light, LightParameter pname, int param);

        public void Lighti(LightName light, LightParameter pname, int param) =>
            lighti(light, pname, param);
        // WINGDIAPI void APIENTRY glLightiv(GLenum light, GLenum pname, const GLint*params);

        [DllImport("opengl32.dll", EntryPoint = "glLightModelf")]
        static extern void lightModelf(LightModelParams pname, IntPtr param);

        public void LightModelf(LightModelParams pname, float[] param)
        {
            if (param == null || param.Length > HeapData.LightfvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(param, 0, HeapData.ptrLightfv, param.Length);
            lightModelf(pname, HeapData.ptrLightfv);
        }


        [DllImport("opengl32.dll", EntryPoint = "glLineStipple")]
        static extern void lineStipple(int factor, ushort pattern);

        public void LineStipple(int factor, ushort pattern)=>
            lineStipple(factor, pattern);


        [DllImport("opengl32.dll", EntryPoint = "glLineWidth")]
        static extern void lineWidth(float width);

        public void LineWidth(float width)=>
             lineWidth(width);


        [DllImport("opengl32.dll", EntryPoint = "glListBase")]
        static extern void listBase(uint listBase);

        public void ListBase(uint listbase)=>
             listBase(listbase);


        [DllImport("opengl32.dll", EntryPoint = "glLoadIdentity")]
        static extern void loadIdentity();

        public void LoadIdentity()=>
            loadIdentity();


        [DllImport("opengl32.dll", EntryPoint = "glLoadMatrixd")]
        static extern void loadMatrixd(IntPtr matrix);

        public void LoadMatrix(double[] matrix)
        {
            if (matrix == null || matrix.Length > HeapData.LoadMatrixdvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(matrix, 0, HeapData.ptrLoadMatrixdv, matrix.Length);
            loadMatrixd(HeapData.ptrLoadMatrixdv);
        }

        [DllImport("opengl32.dll", EntryPoint = "glLoadMatrixf")]
        static extern void loadMatrixf(IntPtr matrix);

        public void LoadMatrix(float[] matrix)
        {
            if (matrix == null || matrix.Length > HeapData.LoadMatrixfvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(matrix, 0, HeapData.ptrLoadMatrixfv, matrix.Length);
            loadMatrixf(HeapData.ptrLoadMatrixfv);
        }


        [DllImport("opengl32.dll", EntryPoint = "glLoadName")]
        static extern void loadName(uint name);

        public void LoadName(uint name)=>
             loadName(name);



        //M


        [DllImport("opengl32.dll", EntryPoint = "glMapGrid1d")]
        static extern void mapGrid1(int un, double u1, double u2);

        public void MapGrid1(int un, double u1, double u2) =>
             mapGrid1( un, u1, u2);


        [DllImport("opengl32.dll", EntryPoint = "glMapGrid1f")]
        static extern void mapGrid1(int un, float u1, float u2);

        public void MapGrid1(int un, float u1, float u2)=>
            mapGrid1(un, u1, u2);


        [DllImport("opengl32.dll", EntryPoint = "glMapGrid2d")]
        static extern void mapGrid2(int un, double u1, double u2, int vn, double v1, double v2);

        public void MapGrid2(int un, double u1, double u2, int vn, double v1, double v2)=>
            mapGrid2(un, u1, u2, vn, v1, v2);


        [DllImport("opengl32.dll", EntryPoint = "glMapGrid2f")]
        static extern void mapGrid2(int un, float u1, float u2, int vn, float v1, float v2);

        public void MapGrid2(int un, float u1, float u2, int vn, float v1, float v2)=>
             mapGrid2(un, u1, u2, vn, v1, v2);

        [DllImport("opengl32.dll", EntryPoint = "glMaterialfv")]
        static extern void materialfv(FacingMode light, LightParameter pname, IntPtr param);

        public void Materialfv(FacingMode light, LightParameter pname, float[] param)
        {
            if (param == null || param.Length > HeapData.MaterialfvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(param, 0, HeapData.ptrMaterialfv, param.Length);
            materialfv(light, pname, HeapData.ptrMaterialfv);
        }


        [DllImport("opengl32.dll", EntryPoint = "glMatrixMode")]
        static extern void matrixMode(MatrixMode mode);

        public void MatrixMode(MatrixMode mode)=>
            matrixMode(mode);

        [DllImport("opengl32.dll", EntryPoint = "glMultMatrixd")]
        static extern void multMatrixd(IntPtr martix);

        public void MultMatrix(double[] matrix)
        {
            if (matrix == null || matrix.Length > HeapData.MultMatrixdvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(matrix, 0, HeapData.ptrMultMatrixdv, matrix.Length);
            multMatrixd(HeapData.ptrMultMatrixdv);
        }

        [DllImport("opengl32.dll", EntryPoint = "glMultMatrixf")]
        static extern void multMatrixf(IntPtr matrix);

        public void MultMatrix(float[] matrix)
        {
            if (matrix == null || matrix.Length > HeapData.MultMatrixfvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(matrix, 0, HeapData.ptrMultMatrixfv, matrix.Length);
            multMatrixf(HeapData.ptrMultMatrixfv);
        }

        //N


        //O


        [DllImport("opengl32.dll", EntryPoint = "glOrtho")]
        static extern void ortho(double left, double right,
            double bottom, double top, double zNear, double zFar);

        public void Ortho(double left, double right,
            double bottom, double top, double zNear, double zFar)=>
            ortho(left, right,
                bottom, top, zNear, zFar);


        //P


        [DllImport("opengl32.dll", EntryPoint = "glPassThrough")]
        static extern void passThrough(float token);

        public void PassThrough(float token)=>
            passThrough(token);


        [DllImport("opengl32.dll", EntryPoint = "glPixelStoref")]
        static extern void pixelStore(PixelStoreParam pname, float param);

        public void PixelStore(PixelStoreParam pname, float param)=>
             pixelStore(pname, param);


        [DllImport("opengl32.dll", EntryPoint = "glPixelStorei")]
        static extern void pixelStore(PixelStoreParam pname, int param);

        public void PixelStore(PixelStoreParam pname, int param)=>
            pixelStore(pname, param);


        [DllImport("opengl32.dll", EntryPoint = "glPixelTransferf")]
        static extern void pixelTransfer(PixelTransferParam pname, float param);

        public void PixelTransfer(PixelTransferParam pname, float param)=>
            pixelTransfer(pname, param);


        [DllImport("opengl32.dll", EntryPoint = "glPixelTransferi")]
        static extern void pixelTransfer(PixelTransferParam panme, int param);

        public void PixelTransfer(PixelTransferParam panme, int param)=>
            pixelTransfer(panme, param);


        [DllImport("opengl32.dll", EntryPoint = "glPixelZoom")]
        static extern void pixelZoom(float xfactor, float yfactor);

        public void PixelZoom(float xfactor, float yfactor)=>
            pixelZoom(xfactor, yfactor);


        [DllImport("opengl32.dll", EntryPoint = "glPointSize")]
        static extern void pointSize(float width);

        public void PointSize(float width)=>
             pointSize(width);


        [DllImport("opengl32.dll", EntryPoint = "glPolygonMode")]
        static extern void polygonMode(FacingMode face, PolygonMode mode);

        public void PolygonMode(FacingMode face, PolygonMode mode)=>
            polygonMode(face, mode);


        [DllImport("opengl32.dll", EntryPoint = "glPolygonOffset")]
        static extern void polygonOffset(float factor, float units);

        public void PolygonOffset(float factor, float units)=>
             polygonOffset(factor, units);


        [DllImport("opengl32.dll", EntryPoint = "glPolygonStipple")]
        static extern void polygonStipple(IntPtr mask);

        public void PolygonStipple(byte[] mask)
        {
            if (mask == null || mask.Length > HeapData.PolygonStipplebvMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(mask, 0, HeapData.ptrPolygonStipplebv, mask.Length);
            polygonStipple(HeapData.ptrPolygonStipplebv);
        }


        [DllImport("opengl32.dll", EntryPoint = "glPopAttrib")]
        static extern void popAttrib();

        public void PopAttrib()=>
            popAttrib();


        [DllImport("opengl32.dll", EntryPoint = "glPopClientAttrib")]
        static extern void popClientAttrib();

        public void PopClientAttrib()=>
            popClientAttrib();


        [DllImport("opengl32.dll", EntryPoint = "glPopMatrix")]
        static extern void popMatrix();

        public void PopMatrix()=>
             popMatrix();


        [DllImport("opengl32.dll", EntryPoint = "glPopName")]
        static extern void popName();

        public void PopName()=>
             popName();


        [DllImport("opengl32.dll", EntryPoint = "glPushAttrib")]
        static extern void pushAttrib(AttributeMask mask);

        public void PushAttrib(AttributeMask mask)=>
            pushAttrib(mask);


        [DllImport("opengl32.dll", EntryPoint = "glPushClientAttrib")]
        static extern void pushClientAttrib(ClientAttributeMask mask);

        public void PushClientAttrib(ClientAttributeMask mask)=> 
            pushClientAttrib(mask);


        [DllImport("opengl32.dll", EntryPoint = "glPushMatrix")]
        static extern void pushMatrix();

        public void PushMatrix()=>
            pushMatrix();


        [DllImport("opengl32.dll", EntryPoint = "glPushName")]
        static extern void pushName(uint name);

        public void PushName(uint name)=>
             pushName(name);


        //Q


        //R


        //S


        [DllImport("opengl32.dll", EntryPoint = "glScissor")]
        static extern void scissor(int x, int y, int width, int height);

        public void Scissor(int x, int y, int width, int height)=>
            scissor(x, y, width, height);


        [DllImport("opengl32.dll", EntryPoint = "glShadeModel")]
        static extern void shadeModel(ShadingModel mode);

        public void ShadeModel(ShadingModel mode)=>
            shadeModel(mode);



        //T
        [DllImport("opengl32.dll", EntryPoint = "glTexImage2D")]
        static extern void texImage2D(
            GetTarget target, int level, PixelDataFormat internalformat, 
            int width, int height, int border, 
            PixelDataFormat format, IndexesDataType type, IntPtr pixels);

        public void TexImage2D(
            GetTarget target, int level, PixelDataFormat internalformat,
            int width, int height, int border,
            PixelDataFormat format, byte[] pixels)
        {
            if (pixels == null || pixels.Length > HeapData.TexImage2DbvMaxSize)
                throw new ArgumentException("Array has to many elements.");
            //IntPtr ptr = Marshal.AllocHGlobal(sizeof(byte) * 2048);
            Marshal.Copy(pixels, 0, HeapData.ptrTexImage2Dbv, pixels.Length);
            texImage2D(target, level, internalformat, 
                width, height, border, format, IndexesDataType.UNSIGNED_BYTE,
                HeapData.ptrTexImage2Dbv);
        }

        [DllImport("opengl32.dll", EntryPoint = "glTexParameteri")]
        static extern void texParameteri(GetTarget target, TextureParameterName pname, TextureMagFilter param);

        public void TexParameteri(GetTarget target, TextureParameterName pname, TextureMagFilter param) =>
            texParameteri(target, pname, param);


        //U


        //V        


        [DllImport("opengl32.dll", EntryPoint = "glViewport")]
        static extern void viewport(int x, int y, uint width, uint height);

        public void Viewport(int x, int y, uint width, uint height)=>
            viewport(x, y, width, height);


        //W


        //X


        //Y


        //Z


        #endregion
    }
}
