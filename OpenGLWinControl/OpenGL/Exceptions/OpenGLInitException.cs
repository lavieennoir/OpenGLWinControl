using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGLWinControl.OpenGL.Exceptions
{

    [Serializable]
    public class OpenGLInitException : Exception
    {
        public OpenGLInitException() { }
        public OpenGLInitException(string message) : base(message) { }
        public OpenGLInitException(string message, Exception inner) : base(message, inner) { }
        protected OpenGLInitException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
