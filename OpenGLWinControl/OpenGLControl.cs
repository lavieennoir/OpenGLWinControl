using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenGLWinControl.OpenGL;
using OpenGLWinControl.OpenGL.Enumerations;
using OpenGLWinControl.OpenGL.Exceptions;

namespace OpenGLWinControl
{
    /// <summary>
    /// User control for C# Windows Forms that encapsulate OpenGL library.
    /// </summary>
    public partial class OpenGLControl : UserControl
    {

        /// <summary>
        ///     Handler for device content.
        /// </summary>
        /// 
        IntPtr hDC;

        /// <summary>
        ///     Handler for openGL resources.
        /// </summary>
        IntPtr hglrc;

        /// <summary>
        ///     Timer for refreshing the scene
        /// </summary>
        Timer refreshTimer;


        /// <summary>
        ///     Action executed when this control is loaded.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Action OnInit { get; set; } = null;

        /// <summary>
        ///     Action executed after Refresh() method
        ///     or every frame if AutoRefresh property set to true.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Action OnRender { get; set; } = null;

        /// <summary>
        ///     If set to true control invokes OnRender action with interval 
        ///     defined in RefreshInterval property.
        ///     Default value is false.
        /// </summary>
        public bool AutoRefresh
        {
            get => refreshTimer.Enabled;
            set => refreshTimer.Enabled = value;
        }

        /// <summary>
        ///     Time in milliseconds between OnRender calls.
        ///     Default value is 33 (equals 30 FPS)
        /// </summary>
        public int RefreshInterval
        {
            get => refreshTimer.Interval;
            set => refreshTimer.Interval = value;
        }

        
        /// <summary>
        ///     Initialize OpenGl Control with default callbacks 
        ///     for inintialization and rendering.
        /// </summary>
        /// <exception cref="OpenGLInitException"></exception>
        public OpenGLControl()
        {
            InitializeComponent();
            InitializeOpenGL();
            InitializeRefreshTimer();
        }
        

        #region Initializing methods

        /// <summary>
        ///     Setup timer to be used for refreshing the scene
        /// </summary>
        void InitializeRefreshTimer()
        {
            refreshTimer = new Timer();
            refreshTimer.Tick += (obj, e) => Refresh();            
            RefreshInterval = 33; // Default value 33 is equal to 30 FPS
        }

        /// <summary>
        ///     Setup Control to use like OpenGL window.
        /// </summary>
        /// <exception cref="OpenGLInitException"></exception>
        void InitializeOpenGL()
        {
            //Get device content handler
            hDC = ContextProcessor.GetDC(this.Handle);

            if (hDC == IntPtr.Zero)
                throw new OpenGLInitException("Can`t get control content handler");

            InitPixelFormat();
        }

        /// <summary>
        ///     Make Windows Forms control compatible with OpenGL calls.
        /// </summary>
        /// <exception cref="OpenGLInitException"></exception>
        void InitPixelFormat()
        {
            // pfd Tells Windows How We Want Things To Be
            ContextProcessor.PIXELFORMATDESCRIPTOR pfd = new ContextProcessor.PIXELFORMATDESCRIPTOR();
            pfd.Init();
            int iPixelFormat;

            // get the device context's best, available pixel format match 
            if ((iPixelFormat = ContextProcessor.ChoosePixelFormat(hDC, ref pfd)) == 0)
                throw new OpenGLInitException("ChoosePixelFormat Failed");

            if (!ContextProcessor.SetPixelFormat(hDC, iPixelFormat, ref pfd))
                throw new OpenGLInitException("SetPixelFormat Failed");

            //create openGL context
            hglrc = ContextProcessor.wglGetCurrentContext();

            if ((hglrc = ContextProcessor.wglCreateContext(hDC)) == IntPtr.Zero)
                throw new OpenGLInitException("wglCreateContext Failed");

            if (!ContextProcessor.wglMakeCurrent(hDC, hglrc))
                throw new OpenGLInitException("wglMakeCurrent Failed");
        }


        /// <summary>
        ///     Iitializes scene using OnInit function
        /// </summary>
        public void InitializeScene()
        {
            if (OnInit == null)
                throw new OpenGLInitException("OnInit function is null");
            else
                OnInit.Invoke();
        }
        

        #endregion


        /// <summary>
        ///     Forces the control to invalidate its client area and immediately redraw itself
        ///     and any child controls.
        ///     Invokes OnRender action.
        /// </summary>
        public override void Refresh()
        {
            base.Refresh();
            if (OnRender != null)
            {
                OnRender();
                //SwapBuffers();
            }
        }
        

        /// <summary>
        ///     Swap control context buffers for double buffered render.
        ///     Need to call after each Render() call.
        /// </summary>
        protected void SwapBuffers()
        {
            ContextProcessor.SwapBuffers(hDC);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        ~OpenGLControl()
        {
            this.DestroyHandle();
        }
    }
}
