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
        [DllImport("opengl32.dll", EntryPoint = "glGetBooleanv")]
        private static extern void GetBooleanv(GetTarget pname, IntPtr param);

        [DllImport("opengl32.dll", EntryPoint = "glGetFloatv")]
        private static extern void GetFloatv(GetTarget pname, IntPtr param);

        [DllImport("opengl32.dll", EntryPoint = "glGetDoublev")]
        private static extern void GetDoublev(GetTarget pname, IntPtr param);

        [DllImport("opengl32.dll", EntryPoint = "glGetIntegerv")]
        private static extern void GetIntegerv(GetTarget pname, IntPtr param);


        public void GetBoolean(GetTarget pname, bool[] param)
        {
            byte[] v = param.Select(x => x ? (byte)1 : (byte)0).ToArray();

            if (param == null || param.Length > HeapData.GetBooleanMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(v, 0, HeapData.ptrGetBoolean, v.Length);
            GetBooleanv(pname, HeapData.ptrGetBoolean);
            Marshal.Copy(HeapData.ptrGetBoolean, v, 0, v.Length);

            for (int i = 0; i < param.Length; i++)
                param[i] = v[i] != 0;
        }


        public void GetFloat(GetTarget pname, float[] param)
        {
            if (param == null || param.Length > HeapData.GetFloatMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(param, 0, HeapData.ptrGetFloat, param.Length);
            GetFloatv(pname, HeapData.ptrGetFloat);
            Marshal.Copy(HeapData.ptrGetFloat, param, 0, param.Length);
        }


        public void GetDouble(GetTarget pname, double[] param)
        {
            if (param == null || param.Length > HeapData.GetDoubleMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(param, 0, HeapData.ptrGetDouble, param.Length);
            GetDoublev(pname, HeapData.ptrGetDouble);
            Marshal.Copy(HeapData.ptrGetDouble, param, 0, param.Length);
        }


        public void GetInteger(GetTarget pname, int[] param)
        {
            if (param == null || param.Length > HeapData.GetIntegerMaxSize)
                throw new ArgumentException("Array has to many elements.");

            Marshal.Copy(param, 0, HeapData.ptrGetInteger, param.Length);
            GetIntegerv(pname, HeapData.ptrGetInteger);
            Marshal.Copy(HeapData.ptrGetInteger, param, 0, param.Length);
        }
    }
}
