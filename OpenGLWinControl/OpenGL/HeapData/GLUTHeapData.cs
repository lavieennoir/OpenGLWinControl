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
    public class GLUTHeapData : HeapData
    {
        internal int AddSubMenuLabelMaxSize { get; set; } = 64;
        internal IntPtr ptrAddSubMenuLabel = IntPtr.Zero;

        internal int AddMenuEntryLabelMaxSize { get; set; } = 64;
        internal IntPtr ptrAddMenuEntryLabel = IntPtr.Zero;

        internal override void AllocHeapPointers()
        {
            ptrAddMenuEntryLabel = Marshal.AllocHGlobal(sizeof(byte) * AddMenuEntryLabelMaxSize);
            ptrAddSubMenuLabel = Marshal.AllocHGlobal(sizeof(byte) * AddSubMenuLabelMaxSize);
        }

        internal override void FreeHeapPointers()
        {
            Marshal.FreeHGlobal(ptrAddSubMenuLabel);
        }
    }
}
