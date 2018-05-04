using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenGLWinControl.OpenGL.HeapData
{
    /// <summary>
    ///     Contains pointers to function arguments of all GL
    ///     function parameters passed by pointer and size of this pointers.
    /// </summary>
    public class GLHeapData : HeapData
    {
        public int TexImage2DbvMaxSize { get; set; } = 66560;
        internal IntPtr ptrTexImage2Dbv = IntPtr.Zero;

        public int MaterialfvMaxSize { get; set; } = 4;
        internal IntPtr ptrMaterialfv = IntPtr.Zero;

        public int VertexPointerbvMaxSize { get; set; } = 1;
        internal IntPtr ptrVertexPointerbv = IntPtr.Zero;

        public int VertexPointersvMaxSize { get; set; } = 1;
        internal IntPtr ptrVertexPointersv = IntPtr.Zero;

        public int VertexPointerivMaxSize { get; set; } = 1;
        internal IntPtr ptrVertexPointeriv = IntPtr.Zero;

        public int VertexPointerfvMaxSize { get; set; } = 1;
        internal IntPtr ptrVertexPointerfv = IntPtr.Zero;

        public int VertexPointerdvMaxSize { get; set; } = 1;
        internal IntPtr ptrVertexPointerdv = IntPtr.Zero;


        internal int Vertex4ivMaxSize { get; set; } = 4;
        internal IntPtr ptrVertex4iv = IntPtr.Zero;

        internal int Vertex4fvMaxSize { get; set; } = 4;
        internal IntPtr ptrVertex4fv = IntPtr.Zero;

        internal int Vertex4dvMaxSize { get; set; } = 4;
        internal IntPtr ptrVertex4dv = IntPtr.Zero;

        internal int Vertex4svMaxSize { get; set; } = 4;
        internal IntPtr ptrVertex4sv = IntPtr.Zero;

        internal int Vertex3ivMaxSize { get; set; } = 3;
        internal IntPtr ptrVertex3iv = IntPtr.Zero;

        internal int Vertex3fvMaxSize { get; set; } = 3;
        internal IntPtr ptrVertex3fv = IntPtr.Zero;

        internal int Vertex3svMaxSize { get; set; } = 3;
        internal IntPtr ptrVertex3sv = IntPtr.Zero;

        internal int Vertex3dvMaxSize { get; set; } = 3;
        internal IntPtr ptrVertex3dv = IntPtr.Zero;

        internal int Vertex2ivMaxSize { get; set; } = 2;
        internal IntPtr ptrVertex2iv = IntPtr.Zero;

        internal int Vertex2fvMaxSize { get; set; } = 2;
        internal IntPtr ptrVertex2fv = IntPtr.Zero;

        internal int Vertex2dvMaxSize { get; set; } = 2;
        internal IntPtr ptrVertex2dv = IntPtr.Zero;

        internal int Vertex2svMaxSize { get; set; } = 2;
        internal IntPtr ptrVertex2sv = IntPtr.Zero;


        internal int TexCoord4ivMaxSize { get; set; } = 4;
        internal IntPtr ptrTexCoord4iv = IntPtr.Zero;

        internal int TexCoord4fvMaxSize { get; set; } = 4;
        internal IntPtr ptrTexCoord4fv = IntPtr.Zero;

        internal int TexCoord4dvMaxSize { get; set; } = 4;
        internal IntPtr ptrTexCoord4dv = IntPtr.Zero;

        internal int TexCoord4svMaxSize { get; set; } = 4;
        internal IntPtr ptrTexCoord4sv = IntPtr.Zero;

        internal int TexCoord3ivMaxSize { get; set; } = 3;
        internal IntPtr ptrTexCoord3iv = IntPtr.Zero;

        internal int TexCoord3fvMaxSize { get; set; } = 3;
        internal IntPtr ptrTexCoord3fv = IntPtr.Zero;

        internal int TexCoord3svMaxSize { get; set; } = 3;
        internal IntPtr ptrTexCoord3sv = IntPtr.Zero;

        internal int TexCoord3dvMaxSize { get; set; } = 3;
        internal IntPtr ptrTexCoord3dv = IntPtr.Zero;

        internal int TexCoord2ivMaxSize { get; set; } = 2;
        internal IntPtr ptrTexCoord2iv = IntPtr.Zero;

        internal int TexCoord2fvMaxSize { get; set; } = 2;
        internal IntPtr ptrTexCoord2fv = IntPtr.Zero;

        internal int TexCoord2dvMaxSize { get; set; } = 2;
        internal IntPtr ptrTexCoord2dv = IntPtr.Zero;

        internal int TexCoord2svMaxSize { get; set; } = 2;
        internal IntPtr ptrTexCoord2sv = IntPtr.Zero;

        internal int TexCoord1ivMaxSize { get; set; } = 1;
        internal IntPtr ptrTexCoord1iv = IntPtr.Zero;

        internal int TexCoord1fvMaxSize { get; set; } = 1;
        internal IntPtr ptrTexCoord1fv = IntPtr.Zero;

        internal int TexCoord1dvMaxSize { get; set; } = 1;
        internal IntPtr ptrTexCoord1dv = IntPtr.Zero;

        internal int TexCoord1svMaxSize { get; set; } = 1;
        internal IntPtr ptrTexCoord1sv = IntPtr.Zero;


        internal int RectsvMaxSize { get; set; } = 4;
        internal IntPtr ptrRectsv = IntPtr.Zero;

        internal int RectivMaxSize { get; set; } = 4;
        internal IntPtr ptrRectiv = IntPtr.Zero;

        internal int RectfvMaxSize { get; set; } = 4;
        internal IntPtr ptrRectfv = IntPtr.Zero;

        internal int RectdvMaxSize { get; set; } = 4;
        internal IntPtr ptrRectdv = IntPtr.Zero;


        public int ReadPixelsfvMaxSize { get; set; } = 1;
        internal IntPtr ptrReadPixelsfv = IntPtr.Zero;

        public int ReadPixelsuivMaxSize { get; set; } = 1;
        internal IntPtr ptrReadPixelsuiv = IntPtr.Zero;

        public int ReadPixelsivMaxSize { get; set; } = 1;
        internal IntPtr ptrReadPixelsiv = IntPtr.Zero;

        public int ReadPixelsusvMaxSize { get; set; } = 1;
        internal IntPtr ptrReadPixelsusv = IntPtr.Zero;

        public int ReadPixelssvMaxSize { get; set; } = 1;
        internal IntPtr ptrReadPixelssv = IntPtr.Zero;

        public int ReadPixelssbvMaxSize { get; set; } = 1;
        internal IntPtr ptrReadPixelssbv = IntPtr.Zero;

        public int ReadPixelsbvMaxSize { get; set; } = 1;
        internal IntPtr ptrReadPixelsbv = IntPtr.Zero;


        internal int RasterPos4dvMaxSize { get; set; } = 4;
        internal IntPtr ptrRasterPos4dv = IntPtr.Zero;

        internal int RasterPos4fvMaxSize { get; set; } = 4;
        internal IntPtr ptrRasterPos4fv = IntPtr.Zero;

        internal int RasterPos4ivMaxSize { get; set; } = 4;
        internal IntPtr ptrRasterPos4iv = IntPtr.Zero;

        internal int RasterPos4svMaxSize { get; set; } = 4;
        internal IntPtr ptrRasterPos4sv = IntPtr.Zero;

        internal int RasterPos3dvMaxSize { get; set; } = 3;
        internal IntPtr ptrRasterPos3dv = IntPtr.Zero;

        internal int RasterPos3fvMaxSize { get; set; } = 3;
        internal IntPtr ptrRasterPos3fv = IntPtr.Zero;

        internal int RasterPos3ivMaxSize { get; set; } = 3;
        internal IntPtr ptrRasterPos3iv = IntPtr.Zero;

        internal int RasterPos3svMaxSize { get; set; } = 3;
        internal IntPtr ptrRasterPos3sv = IntPtr.Zero;

        internal int RasterPos2dvMaxSize { get; set; } = 2;
        internal IntPtr ptrRasterPos2dv = IntPtr.Zero;

        internal int RasterPos2fvMaxSize { get; set; } = 2;
        internal IntPtr ptrRasterPos2fv = IntPtr.Zero;

        internal int RasterPos2ivMaxSize { get; set; } = 2;
        internal IntPtr ptrRasterPos2iv = IntPtr.Zero;

        internal int RasterPos2svMaxSize { get; set; } = 2;
        internal IntPtr ptrRasterPos2sv = IntPtr.Zero;


        public int IndexPointerbvMaxSize { get; set; } = 1;
        internal IntPtr ptrIndexPointerbv = IntPtr.Zero;

        public int IndexPointersvMaxSize { get; set; } = 1;
        internal IntPtr ptrIndexPointersv = IntPtr.Zero;

        public int IndexPointerivMaxSize { get; set; } = 1;
        internal IntPtr ptrIndexPointeriv = IntPtr.Zero;

        public int IndexPointerfvMaxSize { get; set; } = 1;
        internal IntPtr ptrIndexPointerfv = IntPtr.Zero;

        public int IndexPointerdvMaxSize { get; set; } = 1;
        internal IntPtr ptrIndexPointerdv = IntPtr.Zero;


        internal int IndexbvMaxSize { get; set; } = 2;
        internal IntPtr ptrIndexbv = IntPtr.Zero;

        internal int IndexsvMaxSize { get; set; } = 2;
        internal IntPtr ptrIndexsv = IntPtr.Zero;

        internal int IndexivMaxSize { get; set; } = 2;
        internal IntPtr ptrIndexiv = IntPtr.Zero;

        internal int IndexfvMaxSize { get; set; } = 2;
        internal IntPtr ptrIndexfv = IntPtr.Zero;

        internal int IndexdvMaxSize { get; set; } = 2;
        internal IntPtr ptrIndexdv = IntPtr.Zero;


        internal int GetBooleanMaxSize { get; set; } = 2;
        internal IntPtr ptrGetBoolean = IntPtr.Zero;

        internal int GetFloatMaxSize { get; set; } = 2;
        internal IntPtr ptrGetFloat = IntPtr.Zero;

        internal int GetDoubleMaxSize { get; set; } = 2;
        internal IntPtr ptrGetDouble = IntPtr.Zero;

        internal int GetIntegerMaxSize { get; set; } = 2;
        internal IntPtr ptrGetInteger = IntPtr.Zero;


        public int DrawPixelsbvMaxSize { get; set; } = 1;
        internal IntPtr ptrDrawPixelsbv = IntPtr.Zero;

        public int DrawPixelssbvMaxSize { get; set; } = 1;
        internal IntPtr ptrDrawPixelssbv = IntPtr.Zero;

        public int DrawPixelssvMaxSize { get; set; } = 1;
        internal IntPtr ptrDrawPixelssv = IntPtr.Zero;

        public int DrawPixelsusvMaxSize { get; set; } = 1;
        internal IntPtr ptrDrawPixelsusv = IntPtr.Zero;

        public int DrawPixelsivMaxSize { get; set; } = 1;
        internal IntPtr ptrDrawPixelsiv = IntPtr.Zero;

        public int DrawPixelsuivMaxSize { get; set; } = 1;
        internal IntPtr ptrDrawPixelsuiv = IntPtr.Zero;

        public int DrawPixelsfvMaxSize { get; set; } = 1;
        internal IntPtr ptrDrawPixelsfv = IntPtr.Zero;


        public int DrawElementsuivMaxSize { get; set; } = 1;
        internal IntPtr ptrDrawElementsuiv = IntPtr.Zero;

        public int DrawElementsusvMaxSize { get; set; } = 1;
        internal IntPtr ptrDrawElementsusv = IntPtr.Zero;

        public int DrawElementsbvMaxSize { get; set; } = 1;
        internal IntPtr ptrDrawElementsbv = IntPtr.Zero;


        public int PolygonStipplebvMaxSize { get; set; } = 1;
        internal IntPtr ptrPolygonStipplebv = IntPtr.Zero;


        internal int MultMatrixfvMaxSize { get; set; } = 16;
        internal IntPtr ptrMultMatrixfv = IntPtr.Zero;

        internal int MultMatrixdvMaxSize { get; set; } = 16;
        internal IntPtr ptrMultMatrixdv = IntPtr.Zero;


        internal int LoadMatrixfvMaxSize { get; set; } = 16;
        internal IntPtr ptrLoadMatrixfv = IntPtr.Zero;

        internal int LoadMatrixdvMaxSize { get; set; } = 16;
        internal IntPtr ptrLoadMatrixdv = IntPtr.Zero;


        public int InterleavedArraysivMaxSize { get; set; } = 1;
        internal IntPtr ptrInterleavedArraysiv = IntPtr.Zero;

        public int EdgeFlagbvMaxSize { get; set; } = 1;
        internal IntPtr ptrEdgeFlagbv = IntPtr.Zero;

        public int BitmapbvMaxSize { get; set; } = 1;
        internal IntPtr ptrBitmapbv = IntPtr.Zero;


        public int ColorPointerbvMaxSize { get; set; } = 1;
        internal IntPtr ptrColorPointerbv = IntPtr.Zero;

        public int ColorPointersvMaxSize { get; set; } = 1;
        internal IntPtr ptrColorPointersv = IntPtr.Zero;

        public int ColorPointerivMaxSize { get; set; } = 1;
        internal IntPtr ptrColorPointeriv = IntPtr.Zero;

        public int ColorPointerfvMaxSize { get; set; } = 1;
        internal IntPtr ptrColorPointerfv = IntPtr.Zero;

        public int ColorPointerdvMaxSize { get; set; } = 1;
        internal IntPtr ptrColorPointerdv = IntPtr.Zero;

        //colors
        internal int Color3bvMaxSize { get; set; } = 3;
        internal IntPtr ptrColor3bv = IntPtr.Zero;

        internal int Color3sbvMaxSize { get; set; } = 3;
        internal IntPtr ptrColor3sbv = IntPtr.Zero;

        internal int Color3fvMaxSize { get; set; } = 3;
        internal IntPtr ptrColor3fv = IntPtr.Zero;

        internal int Color3dvMaxSize { get; set; } = 3;
        internal IntPtr ptrColor3dv = IntPtr.Zero;

        internal int Color3ivMaxSize { get; set; } = 3;
        internal IntPtr ptrColor3iv = IntPtr.Zero;

        internal int Color3svMaxSize { get; set; } = 3;
        internal IntPtr ptrColor3sv = IntPtr.Zero;

        internal int Color3uivMaxSize { get; set; } = 3;
        internal IntPtr ptrColor3uiv = IntPtr.Zero;

        internal int Color3usvMaxSize { get; set; } = 3;
        internal IntPtr ptrColor3usv = IntPtr.Zero;

        internal int Color4bvMaxSize { get; set; } = 4;
        internal IntPtr ptrColor4bv = IntPtr.Zero;

        internal int Color4sbvMaxSize { get; set; } = 4;
        internal IntPtr ptrColor4sbv = IntPtr.Zero;

        internal int Color4fvMaxSize { get; set; } = 4;
        internal IntPtr ptrColor4fv = IntPtr.Zero;

        internal int Color4dvMaxSize { get; set; } = 4;
        internal IntPtr ptrColor4dv = IntPtr.Zero;

        internal int Color4ivMaxSize { get; set; } = 4;
        internal IntPtr ptrColor4iv = IntPtr.Zero;

        internal int Color4svMaxSize { get; set; } = 4;
        internal IntPtr ptrColor4sv = IntPtr.Zero;

        internal int Color4uivMaxSize { get; set; } = 4;
        internal IntPtr ptrColor4uiv = IntPtr.Zero;

        internal int Color4usvMaxSize { get; set; } = 4;
        internal IntPtr ptrColor4usv = IntPtr.Zero;

        internal int LightfvMaxSize { get; set; } = 4;
        internal IntPtr ptrLightfv = IntPtr.Zero;

        internal int LightModelfvMaxSize { get; set; } = 4;
        internal IntPtr ptrLightModelfv = IntPtr.Zero;

        internal override void AllocHeapPointers()
        {
            ptrTexImage2Dbv = Marshal.AllocHGlobal(sizeof(byte) * TexImage2DbvMaxSize);
            ptrMaterialfv = Marshal.AllocHGlobal(sizeof(float) * MaterialfvMaxSize);
            ptrLightfv = Marshal.AllocHGlobal(sizeof(float) * LightfvMaxSize);

            ptrLightModelfv = Marshal.AllocHGlobal(sizeof(float) * LightModelfvMaxSize);
            ptrVertexPointerbv = Marshal.AllocHGlobal(sizeof(byte) * VertexPointerbvMaxSize);
            ptrVertexPointersv = Marshal.AllocHGlobal(sizeof(short) * VertexPointersvMaxSize);
            ptrVertexPointeriv = Marshal.AllocHGlobal(sizeof(int) * VertexPointerivMaxSize);
            ptrVertexPointerfv = Marshal.AllocHGlobal(sizeof(float) * VertexPointerfvMaxSize);
            ptrVertexPointerdv = Marshal.AllocHGlobal(sizeof(double) * VertexPointerdvMaxSize);

            ptrVertex4iv = Marshal.AllocHGlobal(sizeof(int) * Vertex4ivMaxSize);
            ptrVertex4fv = Marshal.AllocHGlobal(sizeof(float) * Vertex4fvMaxSize);
            ptrVertex4dv = Marshal.AllocHGlobal(sizeof(double) * Vertex4dvMaxSize);
            ptrVertex4sv = Marshal.AllocHGlobal(sizeof(short) * Vertex4svMaxSize);
            ptrVertex3iv = Marshal.AllocHGlobal(sizeof(int) * Vertex3ivMaxSize);
            ptrVertex3fv = Marshal.AllocHGlobal(sizeof(float) * Vertex3fvMaxSize);
            ptrVertex3dv = Marshal.AllocHGlobal(sizeof(double) * Vertex3dvMaxSize);
            ptrVertex3sv = Marshal.AllocHGlobal(sizeof(short) * Vertex3svMaxSize);
            ptrVertex2iv = Marshal.AllocHGlobal(sizeof(int) * Vertex2ivMaxSize);
            ptrVertex2fv = Marshal.AllocHGlobal(sizeof(float) * Vertex2fvMaxSize);
            ptrVertex2dv = Marshal.AllocHGlobal(sizeof(double) * Vertex2dvMaxSize);
            ptrVertex2sv = Marshal.AllocHGlobal(sizeof(short) * Vertex2svMaxSize);

            ptrTexCoord4iv = Marshal.AllocHGlobal(sizeof(int) * TexCoord4ivMaxSize);
            ptrTexCoord4fv = Marshal.AllocHGlobal(sizeof(float) * TexCoord4fvMaxSize);
            ptrTexCoord4dv = Marshal.AllocHGlobal(sizeof(double) * TexCoord4dvMaxSize);
            ptrTexCoord4sv = Marshal.AllocHGlobal(sizeof(short) * TexCoord4svMaxSize);
            ptrTexCoord3iv = Marshal.AllocHGlobal(sizeof(int) * TexCoord3ivMaxSize);
            ptrTexCoord3fv = Marshal.AllocHGlobal(sizeof(float) * TexCoord3fvMaxSize);
            ptrTexCoord3dv = Marshal.AllocHGlobal(sizeof(double) * TexCoord3dvMaxSize);
            ptrTexCoord3sv = Marshal.AllocHGlobal(sizeof(short) * TexCoord3svMaxSize);
            ptrTexCoord2iv = Marshal.AllocHGlobal(sizeof(int) * TexCoord2ivMaxSize);
            ptrTexCoord2fv = Marshal.AllocHGlobal(sizeof(float) * TexCoord2fvMaxSize);
            ptrTexCoord2dv = Marshal.AllocHGlobal(sizeof(double) * TexCoord2dvMaxSize);
            ptrTexCoord2sv = Marshal.AllocHGlobal(sizeof(short) * TexCoord2svMaxSize);
            ptrTexCoord1iv = Marshal.AllocHGlobal(sizeof(int) * TexCoord1ivMaxSize);
            ptrTexCoord1fv = Marshal.AllocHGlobal(sizeof(float) * TexCoord1fvMaxSize);
            ptrTexCoord1dv = Marshal.AllocHGlobal(sizeof(double) * TexCoord1dvMaxSize);
            ptrTexCoord1sv = Marshal.AllocHGlobal(sizeof(short) * TexCoord1svMaxSize);


            ptrRectsv = Marshal.AllocHGlobal(sizeof(short) * RectsvMaxSize);
            ptrRectiv = Marshal.AllocHGlobal(sizeof(int) * RectivMaxSize);
            ptrRectfv = Marshal.AllocHGlobal(sizeof(float) * RectfvMaxSize);
            ptrRectdv = Marshal.AllocHGlobal(sizeof(double) * RectdvMaxSize);

            ptrReadPixelsfv = Marshal.AllocHGlobal(sizeof(float) * ReadPixelsfvMaxSize);
            ptrReadPixelsuiv = Marshal.AllocHGlobal(sizeof(uint) * ReadPixelsuivMaxSize);
            ptrReadPixelsiv = Marshal.AllocHGlobal(sizeof(int) * ReadPixelsivMaxSize);
            ptrReadPixelsusv = Marshal.AllocHGlobal(sizeof(ushort) * ReadPixelsusvMaxSize);
            ptrReadPixelssv = Marshal.AllocHGlobal(sizeof(short) * ReadPixelssvMaxSize);
            ptrReadPixelssbv = Marshal.AllocHGlobal(sizeof(sbyte) * ReadPixelssbvMaxSize);
            ptrReadPixelsbv = Marshal.AllocHGlobal(sizeof(byte) * ReadPixelsbvMaxSize);

            ptrRasterPos4dv = Marshal.AllocHGlobal(sizeof(double) * RasterPos4dvMaxSize);
            ptrRasterPos4fv = Marshal.AllocHGlobal(sizeof(float) * RasterPos4fvMaxSize);
            ptrRasterPos4iv = Marshal.AllocHGlobal(sizeof(int) * RasterPos4ivMaxSize);
            ptrRasterPos4sv = Marshal.AllocHGlobal(sizeof(short) * RasterPos4svMaxSize);
            ptrRasterPos3dv = Marshal.AllocHGlobal(sizeof(double) * RasterPos3dvMaxSize);
            ptrRasterPos3fv = Marshal.AllocHGlobal(sizeof(float) * RasterPos3fvMaxSize);
            ptrRasterPos3iv = Marshal.AllocHGlobal(sizeof(int) * RasterPos3ivMaxSize);
            ptrRasterPos3sv = Marshal.AllocHGlobal(sizeof(short) * RasterPos3svMaxSize);
            ptrRasterPos2dv = Marshal.AllocHGlobal(sizeof(double) * RasterPos2dvMaxSize);
            ptrRasterPos2fv = Marshal.AllocHGlobal(sizeof(float) * RasterPos2fvMaxSize);
            ptrRasterPos2iv = Marshal.AllocHGlobal(sizeof(int) * RasterPos2ivMaxSize);
            ptrRasterPos2sv = Marshal.AllocHGlobal(sizeof(short) * RasterPos2svMaxSize);


            ptrIndexPointerbv = Marshal.AllocHGlobal(sizeof(byte) * IndexPointerbvMaxSize);
            ptrIndexPointersv = Marshal.AllocHGlobal(sizeof(short) * IndexPointersvMaxSize);
            ptrIndexPointeriv = Marshal.AllocHGlobal(sizeof(int) * IndexPointerivMaxSize);
            ptrIndexPointerfv = Marshal.AllocHGlobal(sizeof(float) * IndexPointerfvMaxSize);
            ptrIndexPointerdv = Marshal.AllocHGlobal(sizeof(double) * IndexPointerdvMaxSize);

            ptrIndexbv = Marshal.AllocHGlobal(sizeof(byte) * IndexbvMaxSize);
            ptrIndexsv = Marshal.AllocHGlobal(sizeof(short) * IndexsvMaxSize);
            ptrIndexiv = Marshal.AllocHGlobal(sizeof(int) * IndexivMaxSize);
            ptrIndexfv = Marshal.AllocHGlobal(sizeof(float) * IndexfvMaxSize);
            ptrIndexdv = Marshal.AllocHGlobal(sizeof(double) * IndexdvMaxSize);

            ptrGetBoolean = Marshal.AllocHGlobal(sizeof(byte) * GetBooleanMaxSize);
            ptrGetFloat = Marshal.AllocHGlobal(sizeof(float) * GetFloatMaxSize);
            ptrGetDouble = Marshal.AllocHGlobal(sizeof(double) * GetDoubleMaxSize);
            ptrGetInteger = Marshal.AllocHGlobal(sizeof(int) * GetIntegerMaxSize);

            ptrDrawPixelsbv = Marshal.AllocHGlobal(sizeof(byte) * DrawPixelsbvMaxSize);
            ptrDrawPixelssbv = Marshal.AllocHGlobal(sizeof(sbyte) * DrawPixelssbvMaxSize);
            ptrDrawPixelssv = Marshal.AllocHGlobal(sizeof(short) * DrawPixelssbvMaxSize);
            ptrDrawPixelsusv = Marshal.AllocHGlobal(sizeof(ushort) * DrawPixelssvMaxSize);
            ptrDrawPixelsiv = Marshal.AllocHGlobal(sizeof(int) * DrawPixelsivMaxSize);
            ptrDrawPixelsuiv = Marshal.AllocHGlobal(sizeof(uint) * DrawPixelsuivMaxSize);
            ptrDrawPixelsfv = Marshal.AllocHGlobal(sizeof(float) * DrawPixelsfvMaxSize);
           
            ptrDrawElementsuiv = Marshal.AllocHGlobal(sizeof(uint) * DrawElementsuivMaxSize);
            ptrDrawElementsusv = Marshal.AllocHGlobal(sizeof(ushort) * DrawElementsusvMaxSize);
            ptrDrawElementsbv = Marshal.AllocHGlobal(sizeof(byte) * DrawElementsbvMaxSize);

            ptrPolygonStipplebv = Marshal.AllocHGlobal(sizeof(byte) * PolygonStipplebvMaxSize);

            ptrMultMatrixfv = Marshal.AllocHGlobal(sizeof(float) * MultMatrixfvMaxSize);
            ptrMultMatrixdv = Marshal.AllocHGlobal(sizeof(double) * MultMatrixdvMaxSize);

            ptrLoadMatrixfv = Marshal.AllocHGlobal(sizeof(float) * LoadMatrixfvMaxSize);
            ptrLoadMatrixdv = Marshal.AllocHGlobal(sizeof(double) * LoadMatrixdvMaxSize);

            ptrInterleavedArraysiv = Marshal.AllocHGlobal(sizeof(int) * InterleavedArraysivMaxSize);
            ptrEdgeFlagbv = Marshal.AllocHGlobal(sizeof(byte) * EdgeFlagbvMaxSize);
            ptrBitmapbv = Marshal.AllocHGlobal(sizeof(byte) * BitmapbvMaxSize);

            ptrColorPointerbv = Marshal.AllocHGlobal(sizeof(byte) * ColorPointerbvMaxSize);
            ptrColorPointersv = Marshal.AllocHGlobal(sizeof(short) * ColorPointersvMaxSize);
            ptrColorPointeriv = Marshal.AllocHGlobal(sizeof(int) * ColorPointerivMaxSize);
            ptrColorPointerfv = Marshal.AllocHGlobal(sizeof(float) * ColorPointerfvMaxSize);
            ptrColorPointerdv = Marshal.AllocHGlobal(sizeof(double) * ColorPointerdvMaxSize);

            ptrColor3bv = Marshal.AllocHGlobal(sizeof(byte) * Color3bvMaxSize);
            ptrColor3sbv = Marshal.AllocHGlobal(sizeof(sbyte) * Color3sbvMaxSize);
            ptrColor3fv = Marshal.AllocHGlobal(sizeof(float) * Color3fvMaxSize);
            ptrColor3dv = Marshal.AllocHGlobal(sizeof(double) * Color3dvMaxSize);
            ptrColor3iv = Marshal.AllocHGlobal(sizeof(int) * Color3ivMaxSize);
            ptrColor3sv = Marshal.AllocHGlobal(sizeof(short) * Color3svMaxSize);
            ptrColor3uiv = Marshal.AllocHGlobal(sizeof(uint) * Color3uivMaxSize);
            ptrColor3usv = Marshal.AllocHGlobal(sizeof(ushort) * Color3usvMaxSize);
            ptrColor4bv = Marshal.AllocHGlobal(sizeof(byte) * Color4bvMaxSize);
            ptrColor4sbv = Marshal.AllocHGlobal(sizeof(sbyte) * Color4sbvMaxSize);
            ptrColor4fv = Marshal.AllocHGlobal(sizeof(float) * Color4fvMaxSize);
            ptrColor4dv = Marshal.AllocHGlobal(sizeof(double) * Color4dvMaxSize);
            ptrColor4iv = Marshal.AllocHGlobal(sizeof(int) * Color4ivMaxSize);
            ptrColor4sv = Marshal.AllocHGlobal(sizeof(short) * Color4svMaxSize);
            ptrColor4uiv = Marshal.AllocHGlobal(sizeof(uint) * Color4uivMaxSize);
            ptrColor4usv = Marshal.AllocHGlobal(sizeof(ushort) * Color4usvMaxSize);

            // Note memory has been allocated.
            memoryAllocated = true;
        }

        internal override void FreeHeapPointers()
        {
            // Check to see if FreeHeapPointers has already been called.
            if (!this.memoryAllocated)
            {
                Marshal.FreeHGlobal(ptrTexImage2Dbv);
                Marshal.FreeHGlobal(ptrMaterialfv);
                Marshal.FreeHGlobal(ptrLightModelfv);
                Marshal.FreeHGlobal(ptrLightfv);
                Marshal.FreeHGlobal(ptrVertexPointerbv);
                Marshal.FreeHGlobal(ptrVertexPointersv);
                Marshal.FreeHGlobal(ptrVertexPointeriv);
                Marshal.FreeHGlobal(ptrVertexPointerfv);
                Marshal.FreeHGlobal(ptrVertexPointerdv);

                Marshal.FreeHGlobal(ptrVertex4iv);
                Marshal.FreeHGlobal(ptrVertex4fv);
                Marshal.FreeHGlobal(ptrVertex4dv);
                Marshal.FreeHGlobal(ptrVertex4sv);
                Marshal.FreeHGlobal(ptrVertex3iv);
                Marshal.FreeHGlobal(ptrVertex3fv);
                Marshal.FreeHGlobal(ptrVertex3dv);
                Marshal.FreeHGlobal(ptrVertex3sv);
                Marshal.FreeHGlobal(ptrVertex2iv);
                Marshal.FreeHGlobal(ptrVertex2fv);
                Marshal.FreeHGlobal(ptrVertex2dv);
                Marshal.FreeHGlobal(ptrVertex2sv);

                Marshal.FreeHGlobal(ptrTexCoord4iv);
                Marshal.FreeHGlobal(ptrTexCoord4fv);
                Marshal.FreeHGlobal(ptrTexCoord4dv);
                Marshal.FreeHGlobal(ptrTexCoord4sv);
                Marshal.FreeHGlobal(ptrTexCoord3iv);
                Marshal.FreeHGlobal(ptrTexCoord3fv);
                Marshal.FreeHGlobal(ptrTexCoord3dv);
                Marshal.FreeHGlobal(ptrTexCoord3sv);
                Marshal.FreeHGlobal(ptrTexCoord2iv);
                Marshal.FreeHGlobal(ptrTexCoord2fv);
                Marshal.FreeHGlobal(ptrTexCoord2dv);
                Marshal.FreeHGlobal(ptrTexCoord2sv);
                Marshal.FreeHGlobal(ptrTexCoord1iv);
                Marshal.FreeHGlobal(ptrTexCoord1fv);
                Marshal.FreeHGlobal(ptrTexCoord1dv);
                Marshal.FreeHGlobal(ptrTexCoord1sv);


                Marshal.FreeHGlobal(ptrRectsv);
                Marshal.FreeHGlobal(ptrRectiv);
                Marshal.FreeHGlobal(ptrRectfv);
                Marshal.FreeHGlobal(ptrRectdv);

                Marshal.FreeHGlobal(ptrReadPixelsfv);
                Marshal.FreeHGlobal(ptrReadPixelsuiv);
                Marshal.FreeHGlobal(ptrReadPixelsiv);
                Marshal.FreeHGlobal(ptrReadPixelsusv);
                Marshal.FreeHGlobal(ptrReadPixelssv);
                Marshal.FreeHGlobal(ptrReadPixelssbv);
                Marshal.FreeHGlobal(ptrReadPixelsbv);

                Marshal.FreeHGlobal(ptrRasterPos4dv);
                Marshal.FreeHGlobal(ptrRasterPos4fv);
                Marshal.FreeHGlobal(ptrRasterPos4iv);
                Marshal.FreeHGlobal(ptrRasterPos4sv);
                Marshal.FreeHGlobal(ptrRasterPos3dv);
                Marshal.FreeHGlobal(ptrRasterPos3fv);
                Marshal.FreeHGlobal(ptrRasterPos3iv);
                Marshal.FreeHGlobal(ptrRasterPos3sv);
                Marshal.FreeHGlobal(ptrRasterPos2dv);
                Marshal.FreeHGlobal(ptrRasterPos2fv);
                Marshal.FreeHGlobal(ptrRasterPos2iv);
                Marshal.FreeHGlobal(ptrRasterPos2sv);


                Marshal.FreeHGlobal(ptrIndexPointerbv);
                Marshal.FreeHGlobal(ptrIndexPointersv);
                Marshal.FreeHGlobal(ptrIndexPointeriv);
                Marshal.FreeHGlobal(ptrIndexPointerfv);
                Marshal.FreeHGlobal(ptrIndexPointerdv);

                Marshal.FreeHGlobal(ptrIndexbv);
                Marshal.FreeHGlobal(ptrIndexsv);
                Marshal.FreeHGlobal(ptrIndexiv);
                Marshal.FreeHGlobal(ptrIndexfv);
                Marshal.FreeHGlobal(ptrIndexdv);

                Marshal.FreeHGlobal(ptrGetBoolean);
                Marshal.FreeHGlobal(ptrGetFloat);
                Marshal.FreeHGlobal(ptrGetDouble);
                Marshal.FreeHGlobal(ptrGetInteger);

                Marshal.FreeHGlobal(ptrDrawPixelsbv);
                Marshal.FreeHGlobal(ptrDrawPixelssbv);
                Marshal.FreeHGlobal(ptrDrawPixelssv);
                Marshal.FreeHGlobal(ptrDrawPixelsusv);
                Marshal.FreeHGlobal(ptrDrawPixelsiv);
                Marshal.FreeHGlobal(ptrDrawPixelsuiv);
                Marshal.FreeHGlobal(ptrDrawPixelsfv);

                Marshal.FreeHGlobal(ptrDrawElementsuiv);
                Marshal.FreeHGlobal(ptrDrawElementsusv);
                Marshal.FreeHGlobal(ptrDrawElementsbv);

                Marshal.FreeHGlobal(ptrPolygonStipplebv);

                Marshal.FreeHGlobal(ptrMultMatrixfv);
                Marshal.FreeHGlobal(ptrMultMatrixdv);

                Marshal.FreeHGlobal(ptrLoadMatrixfv);
                Marshal.FreeHGlobal(ptrLoadMatrixdv);

                Marshal.FreeHGlobal(ptrInterleavedArraysiv);
                Marshal.FreeHGlobal(ptrEdgeFlagbv);
                Marshal.FreeHGlobal(ptrBitmapbv);

                Marshal.FreeHGlobal(ptrColorPointerbv);
                Marshal.FreeHGlobal(ptrColorPointersv);
                Marshal.FreeHGlobal(ptrColorPointeriv);
                Marshal.FreeHGlobal(ptrColorPointerfv);
                Marshal.FreeHGlobal(ptrColorPointerdv);

                Marshal.FreeHGlobal(ptrColor3bv);
                Marshal.FreeHGlobal(ptrColor3sbv);
                Marshal.FreeHGlobal(ptrColor3fv);
                Marshal.FreeHGlobal(ptrColor3dv);
                Marshal.FreeHGlobal(ptrColor3iv);
                Marshal.FreeHGlobal(ptrColor3sv);
                Marshal.FreeHGlobal(ptrColor3uiv);
                Marshal.FreeHGlobal(ptrColor3usv);
                Marshal.FreeHGlobal(ptrColor4bv);
                Marshal.FreeHGlobal(ptrColor4sbv);
                Marshal.FreeHGlobal(ptrColor4fv);
                Marshal.FreeHGlobal(ptrColor4dv);
                Marshal.FreeHGlobal(ptrColor4iv);
                Marshal.FreeHGlobal(ptrColor4sv);
                Marshal.FreeHGlobal(ptrColor4uiv);
                Marshal.FreeHGlobal(ptrColor4usv);

                // Note memory has been released.
                memoryAllocated = false;
            }
        }
    }
}
