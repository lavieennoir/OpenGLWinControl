using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGLWinControl.OpenGL.HeapData
{
    public abstract class HeapData : IDisposable
    {

        /// <summary>
        ///     Track whether Dispose has been called.
        /// </summary>
        protected bool memoryAllocated = false;

        /// <summary>
        ///     Allocate all memory in heap will be used by class.
        /// </summary>
        internal abstract void AllocHeapPointers();

        /// <summary>
        ///     Free all memory in heap used by class.
        /// </summary>
        internal abstract void FreeHeapPointers();

        
        public void Dispose()
        {
            FreeHeapPointers();
            GC.SuppressFinalize(this);
        }


        ~HeapData()
        {
            FreeHeapPointers();
        }
    }
}
