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
        [DllImport("opengl32.dll", EntryPoint = "glGetString")]
        private static extern IntPtr getString(InfoStringName name);


        public string GetString(InfoStringName name)
        {
            byte[] buf = new byte[256];
            InvokeWithArrayPointer(ref buf,
                (ptr) =>
                {
                    Marshal.Copy(getString(name), buf, 0, buf.Length);
                });
            return new string(
                    buf.Select(x => (char)x).ToArray()
                ).TrimEnd(' ', '\t', '\n', '\0')
                .Replace('\0', '\n');
        }
        
    }
}
