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
        [DllImport("opengl32.dll", EntryPoint = "glGetBooleanv")]
        private static extern void GetBooleanv(GetTarget pname, IntPtr param);

        [DllImport("opengl32.dll", EntryPoint = "glGetFloatv")]
        private static extern void GetFloatv(GetTarget pname, IntPtr param);

        [DllImport("opengl32.dll", EntryPoint = "glGetDoublev")]
        private static extern void GetDoublev(GetTarget pname, IntPtr param);

        [DllImport("opengl32.dll", EntryPoint = "glGetIntegerv")]
        private static extern void GetIntegerv(GetTarget pname, IntPtr param);


        public static void GetBooleanv(GetTarget pname, bool[] param)
        {
            byte[] v = param.Select(x => x ? (byte)1 : (byte)0).ToArray();
            InvokeWithArrayPointer(ref v,
                (ptr) =>
                {
                    Marshal.Copy(v, 0, ptr, v.Length);
                    GetBooleanv(pname, ptr);
                    Marshal.Copy(ptr, v, 0, v.Length);
                });
            for (int i = 0; i < param.Length; i++)
                param[i] = v[i] != 0;
        }


        public static void GetFloatv(GetTarget pname, float[] param) =>
            InvokeWithArrayPointer(ref param,
                (ptr) =>
                {
                    Marshal.Copy(param, 0, ptr, param.Length);
                    GetBooleanv(pname, ptr);
                    Marshal.Copy(ptr, param, 0, param.Length);
                });


        public static void GetFloatv(GetTarget pname, double[] param) =>
            InvokeWithArrayPointer(ref param,
                (ptr) =>
                {
                    Marshal.Copy(param, 0, ptr, param.Length);
                    GetBooleanv(pname, ptr);
                    Marshal.Copy(ptr, param, 0, param.Length);
                });


        public static void GetFloatv(GetTarget pname, int[] param) =>
            InvokeWithArrayPointer(ref param,
                (ptr) =>
                {
                    Marshal.Copy(param, 0, ptr, param.Length);
                    GetBooleanv(pname, ptr);
                    Marshal.Copy(ptr, param, 0, param.Length);
                });
    }
}
