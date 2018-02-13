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
        /// <param name="contextWidth">
        ///     With of rendering area on screen in pixels.
        /// </param>
        /// <param name="contextHeight">
        ///     Height of rendering area on screen in pixels.
        /// </param>
        void Init(int contextWidth, int contextHeight);

        /// <summary>
        ///     Executed when OpenGLControl.Render() called.
        ///     Or every frame if OpenGLControl.AutoRefresh property set to true.
        /// </summary>
        /// <param name="contextWidth">
        ///     With of rendering area on screen in pixels.
        /// </param>
        /// <param name="contextHeight">
        ///     Height of rendering area on screen in pixels.
        /// </param>
        void Render(int contextWidth, int contextHeight);
        
        /// <summary>
        ///     Executed when this control size changed.
        /// </summary>
        /// <param name="contextWidth">
        ///     With of rendering area on screen in pixels.
        /// </param>
        /// <param name="contextHeight">
        ///     Height of rendering area on screen in pixels.
        /// </param>
        void Resize(int contextWidth, int contextHeight);
    }
}
