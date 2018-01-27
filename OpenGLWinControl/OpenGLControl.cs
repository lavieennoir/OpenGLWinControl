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


        Action onInit;

        /// <summary>
        ///     Action executed when this control is loaded.
        ///     When new value set control automaticaly reloads.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Action OnInit
        {
            get
            {
                return onInit;
            }
            set
            {
                onInit = value;
                onInit?.Invoke();
            }
        }

        /// <summary>
        ///     Action executed after Refresh() method
        ///     or every frame if AutoRefresh property set to true.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Action OnRender { get; set; }

        /// <summary>
        ///     If set to true control invokes OnRender action with interval 
        ///     defined in RefreshInterval property.
        ///     Default value is false.
        /// </summary>
        public bool AutoRefresh { get; set; } = false;

        /// <summary>
        ///     Time in milliseconds between OnRender calls.
        ///     Default value is 33 (equal 30 FPS)
        /// </summary>
        public uint RefreshInterval { get; set; } = 33;

        #region Constructors

        /// <summary>
        ///     Initialize OpenGl Control with default callbacks.
        /// </summary>
        /// <exception cref="OpenGLInitException"></exception>
        public OpenGLControl()
        {
            onInit = DefaultInit;
            OnRender = DefaultRender;

            InitializeComponent();
            InitializeOpenGL();
        }


        /// <summary>
        ///     Initialize OpenGl Control with defined callback for Init
        /// </summary>
        /// <param name="OnInit">
        ///     Action executed when this control is loaded.
        ///     null value set default init action.
        /// </param>
        /// <exception cref="OpenGLInitException"></exception>
        public OpenGLControl(Action OnInit)
        {
            if (onInit != null)
                this.onInit = OnInit;
            else
                this.onInit = DefaultInit;

            OnRender = DefaultRender;

            InitializeComponent();
            InitializeOpenGL();
        }


        /// <summary>
        ///     Initialize OpenGl Control with defined callback for Init and Render.
        /// </summary>
        /// <param name="OnInit">
        ///     Action executed when this control is loaded.
        ///     null value set default Init action.
        /// </param>
        /// <param name="OnRender">
        ///     Action executed after Refresh() method
        ///     or every frame if AutoRefresh property set to true.
        ///     null value set default Render action.
        /// </param>
        /// <exception cref="OpenGLInitException"></exception>
        public OpenGLControl(Action OnInit, Action OnRender)
        {
            if (onInit != null)
                this.onInit = OnInit;
            else
                this.onInit = DefaultInit;
            if (OnRender != null)
                this.OnRender = OnRender;
            else
                this.OnRender = DefaultRender;

            InitializeComponent();
            InitializeOpenGL();
        }

        #endregion

        #region Initializing methods

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

            //If everything is ok init scene
            OnInit?.Invoke();
            //redraw scene when control resized
            Resize += (obj,e) => OnRender();
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
        ///     Default callback for OnInit action.
        /// </summary>
        protected virtual void DefaultInit()
        {
            GL.ShadeModel(ShadingModel.GL_SMOOTH); // Enable smooth shading
            GL.ClearColor(0.0f, 0.0f, 0.0f, 0.5f); // Black background
            GL.ClearDepth(1.0f);                   // Depth buffer setup
            GL.Enable(GetTarget.GL_DEPTH_TEST);    // Enable Depth test
        }

        /// <summary>
        ///     Default callback for OnRender action.
        /// </summary>
        protected virtual void DefaultRender()
        {
            GL.Clear(AttributeMask.GL_COLOR_BUFFER_BIT
                | AttributeMask.GL_DEPTH_BUFFER_BIT); // Clear screen and depth buffer
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
                SwapBuffers();
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
