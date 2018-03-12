using OpenGLWinControl.OpenGL.HeapData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGLWinControl.OpenGL
{
    /// <summary>
    ///     Defines methods must be implemented
    ///     to configure OpenGLControl object rendering process.
    /// </summary>
    public interface IRenderingContext
    {
        /// <summary>
        ///     Executed when this control is loaded or Rendering context was reasigned.
        /// </summary>
        /// <param name="gl">
        ///     GL library function provider.
        /// </param>
        /// <param name="glu">
        ///     GLU library function provider.
        /// </param>
        /// <param name="glut">
        ///     GLUT library function provider.
        /// </param>
        /// <param name="contextWidth">
        ///     With of rendering area on screen in pixels.
        /// </param>
        /// <param name="contextHeight">
        ///     Height of rendering area on screen in pixels.
        /// </param>
        void Init(GL gl, GLU glu, GLUT glut, int contextWidth, int contextHeight);

        /// <summary>
        ///     Executed when OpenGLControl.Render() called.
        ///     Or every frame if OpenGLControl.AutoRefresh property set to true.
        /// </summary>
        /// <param name="gl">
        ///     GL library function provider.
        /// </param>
        /// <param name="glu">
        ///     GLU library function provider.
        /// </param>
        /// <param name="glut">
        ///     GLUT library function provider.
        /// </param>
        /// <param name="contextWidth">
        ///     With of rendering area on screen in pixels.
        /// </param>
        /// <param name="contextHeight">
        ///     Height of rendering area on screen in pixels.
        /// </param>
        void Render(GL gl, GLU glu, GLUT glut, int contextWidth, int contextHeight);

        /// <summary>
        ///     Executed when this control size changed.
        /// </summary>
        /// <param name="gl">
        ///     GL library function provider.
        /// </param>
        /// <param name="glu">
        ///     GLU library function provider.
        /// </param>
        /// <param name="glut">
        ///     GLUT library function provider.
        /// </param>
        /// <param name="contextWidth">
        ///     With of rendering area on screen in pixels.
        /// </param>
        /// <param name="contextHeight">
        ///     Height of rendering area on screen in pixels.
        /// </param>
        void Resize(GL gl, GLU glu, GLUT glut, int contextWidth, int contextHeight);

        /// <summary>
        ///     Configures limits of data GL method can accept.
        ///     Return null or new GLHeapData() for default values.
        /// </summary>
        /// <returns>
        ///     Configured GL limits
        /// </returns>
        GLHeapData SetupGLDataLimits();

        /// <summary>
        ///     Configures limits of data GLUT method can accept.
        ///     Return null or new GLHeapData() for default values.
        /// </summary>
        /// <returns>
        ///     Configured GLU limits
        /// </returns>
        GLUHeapData SetupGLUDataLimits();

        /// <summary>
        ///     Configures limits of data GLUT method can accept.
        ///     Return null or new GLHeapData() for default values.
        /// </summary>
        /// <returns>
        ///     Configured GLUT limits
        /// </returns>
        GLUTHeapData SetupGLUTDataLimits();
    }
}
